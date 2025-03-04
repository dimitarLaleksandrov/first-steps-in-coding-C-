using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.Portfolio = new List<Stock>();
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;          
        }



        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        

        public int Count() => Portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                this.Portfolio.Add(stock);
                MoneyToInvest -= stock.MarketCapitalization;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            foreach (var stock in this.Portfolio) 
            {
                if (stock.CompanyName == companyName && stock.MarketCapitalization == sellPrice)
                {
                    if (stock.MarketCapitalization < stock.PricePerShare)
                    {
                        return $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        this.Portfolio.Remove(stock);
                        MoneyToInvest += stock.MarketCapitalization;
                        return $"{companyName} was sold.";
                    }
                }
            }
            return $"{companyName} does not exist.";
        }
       
        public Stock FindStock(string companyName)
        {
            foreach(var stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (this.Portfolio.Count == 0)
            {
                return null;
            }
             
            //return this.Portfolio.OrderByDescending(s => s.MarketCapitalization).FirstOrDefault();
            Stock stockWhitMaxMarketCapitalization = null;
            foreach (var stock in this.Portfolio)
            {
                if (stock.MarketCapitalization > stockWhitMaxMarketCapitalization.MarketCapitalization)
                {
                    stockWhitMaxMarketCapitalization = stock;
                }
            }

            return stockWhitMaxMarketCapitalization;
        }

        public string InvestorInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");
            foreach (var stock in Portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString();
        }

    }

}
