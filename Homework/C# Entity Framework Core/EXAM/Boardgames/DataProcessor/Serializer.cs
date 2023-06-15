namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCreatorsDto[]), new XmlRootAttribute("Creators"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            using StringWriter sw = new StringWriter(sb);

            var creators = context.Creators
                                  .Where(c => c.Boardgames.Any())
                                  .ToArray()
                                  .Select(c => new ExportCreatorsDto()
                                  {
                                      CreatorName = $"{c.FirstName} {c.LastName}",
                                      BoardgamesCount = c.Boardgames.Count(),
                                      Boardgames = c.Boardgames
                                                    .Select(bg => new ExportBoardgameDto()
                                                    {
                                                        BoardgameName = bg.Name,
                                                        BoardgameYearPublished = bg.YearPublished
                                                    })
                                                    .OrderBy(bg => bg.BoardgameName)
                                                    .ToArray()
                                  })
                                  .OrderByDescending(c => c.BoardgamesCount)
                                  .ThenBy(c => c.CreatorName)
                                  .ToArray();

            xmlSerializer.Serialize(sw, creators, namespaces);
            return sb.ToString().TrimEnd();
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellers = context.Sellers
                                  .Where(s => s.BoardgamesSellers.Any(bs => bs.Boardgame.YearPublished >= year && bs.Boardgame.Rating <= rating))
                                  .ToArray()
                                  .Select(s => new ExportsSellerDto()
                                  {
                                      Name = s.Name,
                                      Website = s.Website,
                                      Boardgames = s.BoardgamesSellers.Select(s => s.Boardgame)
                                                    .Where(s => s.YearPublished >= year && s.Rating <= rating)
                                                    .OrderByDescending(x => x.Rating)
                                                    .ThenBy(x => x.Name)
                                                    .Select(bg => new ExportJsonBoardgameDto()
                                                    {
                                                        Name = bg.Name,
                                                        Rating = bg.Rating,
                                                        Mechanics = bg.Mechanics,
                                                        Category = bg.CategoryType.ToString()
                                                    })
                                                    .ToArray()
                                  })
                                  .OrderByDescending(s => s.Boardgames.Count())
                                  .ThenBy(s => s.Name)
                                  .Take(5)
                                  .ToArray();

            return JsonConvert.SerializeObject(sellers, Formatting.Indented);
        }
    }
}