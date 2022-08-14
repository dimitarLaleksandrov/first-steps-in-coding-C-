using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        private string connectionType;
        protected Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) : base(id, manufacturer, model, price, overallPerformance)
        {
            ConnectionType = connectionType;
        }

        public string ConnectionType
        {
            get { return connectionType; }
            set { connectionType = value; }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString() + $" Connection Type: {ConnectionType}");
            return sb.ToString();
        }
    }
}
