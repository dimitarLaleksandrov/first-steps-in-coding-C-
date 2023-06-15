namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCreatorDto[]), new XmlRootAttribute("Creators"));
            using StringReader stringReader = new StringReader(xmlString);
            ImportCreatorDto[] creatorDtos = (ImportCreatorDto[])xmlSerializer.Deserialize(stringReader);
            foreach (var creatorDto in creatorDtos)
            {
                if (!IsValid(creatorDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var creator = new Creator()
                {
                    FirstName = creatorDto.FirstName,
                    LastName = creatorDto.LastName,
                };
                foreach (var bordgameDto in creatorDto.Boardgames)
                {
                    if (!IsValid(bordgameDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }  
                    var boardgame = new Boardgame()
                    {
                        Name = bordgameDto.Name,
                        Rating = bordgameDto.Rating,
                        YearPublished = bordgameDto.YearPublished,
                        CategoryType = (CategoryType)bordgameDto.CategoryType,
                        Mechanics = bordgameDto.Mechanics
                    };
                    creator.Boardgames.Add(boardgame);
                }
                context.Creators.Add(creator);
                sb.AppendLine(String.Format(SuccessfullyImportedCreator, creator.FirstName, creator.LastName, creator.Boardgames.Count));
            } 
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportSellerDto[] sellerDtos = JsonConvert.DeserializeObject<ImportSellerDto[]>(jsonString);
            foreach (var sellerDto in sellerDtos)
            {
                if (!IsValid(sellerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var seller = new Seller()
                {
                   Name = sellerDto.Name,
                   Address = sellerDto.Address,
                   Country = sellerDto.Country,
                   Website = sellerDto.Website
                };
                foreach (var boardgameId in sellerDto.Boardgames.Distinct())
                {
                    var boardgame = context.Boardgames.Find(boardgameId);
                    if (boardgame == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    seller.BoardgamesSellers.Add(new BoardgameSeller
                    {
                       Boardgame = boardgame
                    });
                }
                context.Sellers.Add(seller);
                sb.AppendLine(String.Format(SuccessfullyImportedSeller, seller.Name, seller.BoardgamesSellers.Count));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
