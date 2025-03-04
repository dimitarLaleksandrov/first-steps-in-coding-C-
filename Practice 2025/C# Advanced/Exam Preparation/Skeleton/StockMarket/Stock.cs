using System;
using System.Diagnostics;
using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;                     
            this.MarketCapitalization = pricePerShare * totalNumberOfShares;
        }


        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }       
        public decimal MarketCapitalization { get; set; }


        public override string ToString() 
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Company: {CompanyName}");
            sb.AppendLine($"Director: {Director}");
            sb.AppendLine($"Price per share: ${PricePerShare}");
            sb.AppendLine($"Market capitalization: ${MarketCapitalization}");

            //return sb.ToString();

            return $"Company: {CompanyName}" + Environment.NewLine +
                   $"Director: {Director}" + Environment.NewLine +
                   $"Price per share: ${PricePerShare}" + Environment.NewLine +
                   $"Market capitalization: ${MarketCapitalization}";           
        }
    }
}
