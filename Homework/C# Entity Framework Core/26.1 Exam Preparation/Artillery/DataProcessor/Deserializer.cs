namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string ErrorMessage =
            "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var deserializer = new XmlSerializer(typeof(ImportCountryDto[]), new XmlRootAttribute("Countries"));
            var countriesDto = (ImportCountryDto[])deserializer.Deserialize(new StringReader(xmlString));
            var countries = new List<Country>();
            foreach (var cDto in countriesDto)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var country = new Country()
                {
                    CountryName = cDto.CountryName,
                    ArmySize = cDto.ArmySize
                };
                countries.Add(country);
                sb.AppendLine(string.Format(SuccessfulImportCountry, country.CountryName, country.ArmySize));
            }
            context.Countries.AddRange(countries);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var deserializer = new XmlSerializer(typeof(ImportManufacturersDto[]), new XmlRootAttribute("Manufacturers"));
            var manufacturersDto = (ImportManufacturersDto[])deserializer.Deserialize(new StringReader(xmlString));
            var manufacturers = new List<Manufacturer>();
            foreach (var cDto in manufacturersDto)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var manufacturer = new Manufacturer()
                {
                    ManufacturerName = cDto.ManufacturerName,
                    Founded = cDto.Founded
                };
                manufacturers.Add(manufacturer);
                sb.AppendLine(string.Format(SuccessfulImportManufacturer, manufacturer.ManufacturerName, manufacturer.Founded));
            }
            context.Manufacturers.AddRange(manufacturers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();

        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var deserializer = new XmlSerializer(typeof(ImportShellsDto[]), new XmlRootAttribute("Shells"));
            var shellDto = (ImportShellsDto[])deserializer.Deserialize(new StringReader(xmlString));
            var shells = new List<Shell>();
            foreach (var sDto in shellDto)
            {
                if (!IsValid(sDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var shell = new Shell()
                {
                    ShellWeight = sDto.ShellWeight,
                    Caliber = sDto.Caliber
                };
                shells.Add(shell);
                sb.AppendLine(string.Format(SuccessfulImportShell, shell.Caliber, shell.ShellWeight));
            }
            context.Shells.AddRange(shells);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            var sb = new StringBuilder();
            //var validGunTypes = new string[] { "Howitzer", "Mortar", "FieldGun", "AntiAircraftGun", "MountainGun", "AntiTankGun" };
            var gunsDto = JsonConvert.DeserializeObject<ImportGunsDto[]>(jsonString);
            var guns = new List<Gun>();
            foreach (var gDto in gunsDto)
            {
                if (!IsValid(gDto))     
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var gun = new Gun
                {
                    ManufacturerId = gDto.ManufacturerId,
                    GunWeight = gDto.GunWeight,
                    BarrelLength = gDto.BarrelLength,
                    NumberBuild = gDto.NumberBuild,
                    Range = gDto.Range,
                    GunType = (GunType)Enum.Parse(typeof(GunType), gDto.GunType),
                    ShellId = gDto.ShellId
                };

                foreach (var countryDto in gDto.Countries)
                {
                    gun.CountriesGuns.Add(new CountryGun
                    {
                        CountryId = countryDto.Id
                    });

                }
                guns.Add(gun);
                sb.AppendLine(string.Format(SuccessfulImportGun, gDto.GunType, gDto.GunWeight, gDto.BarrelLength));
            }
            context.Guns.AddRange(guns);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}