using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {

        private List<Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }
        public List<Stock> Portfolio
        {
            get { return portfolio; }
            set
            {
                portfolio = value;
            }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public decimal MoneyToInvest 
        { 
            get { return moneyToInvest; }
            set
            {
                moneyToInvest = value;
            }
        }
        public string BrokerName
        {
            get { return brokerName; }
            set
            {
                brokerName = value;
            }
        }
        public int Count
        {
            get => this.portfolio.Count;
        }
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && moneyToInvest >= stock.PricePerShare)
            {
                this.portfolio.Add(stock);
                moneyToInvest -= stock.MarketCapitalization;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            foreach (var stock in this.portfolio)
            {
                if(stock.CompanyName == companyName)
                {
                    if(sellPrice < stock.PricePerShare)
                    {
                        return $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        this.portfolio.Remove(stock);
                        MoneyToInvest += sellPrice;
                        return $"{companyName} was sold.";
                    }
                }
            }
            return $"{companyName} does not exist.";
        }
        public Stock FindStock(string companyName)
        {
            foreach (var stock in this.portfolio)
            {
                if(stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }
        public Stock FindBiggestCompany()
        {
            if(this.portfolio.Count == 0)
            {
                return null;
            }
            Stock maxStock = null;
            decimal maxStockValue = 0;
            foreach (var stock in this.portfolio)
            {
                if (stock.MarketCapitalization > maxStockValue)
                {
                    maxStockValue = stock.MarketCapitalization;
                    maxStock = stock;
                }
            }
            return maxStock;
            //return this.portfolio.OrderByDescending(s => s.MarketCapitalization).First();
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in this.portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString();
        }
    }
}
