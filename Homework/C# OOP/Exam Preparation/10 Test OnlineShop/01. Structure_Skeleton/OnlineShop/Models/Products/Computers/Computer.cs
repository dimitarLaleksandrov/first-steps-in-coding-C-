using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;
        private double overallPerformance;
        private decimal price;
        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
            OverallPerformance = overallPerformance;
            Price = price;
        }
        public new double OverallPerformance
        {
            get { return overallPerformance; }
            private set
            {
                if (components.Count == 0)
                {
                    value = base.OverallPerformance;
                }
                value = Components.Count * base.OverallPerformance;
                OverallPerformance = value;
            }
        }
        public new decimal Price
        {
            get { return price; }
            private set
            {
                value = (components.Count * base.Price) + (peripherals.Count * base.Price);
                price = value;
            }
        }
        public IReadOnlyCollection<IComponent> Components
        {
            get { return components; }
        }
        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get { return peripherals; }
        }
        public void AddComponent(IComponent component)
        {
            if (components.Contains(component))
            {
                throw new ArgumentException($"Component {component.GetType()} already exists in {GetType()} with Id {component.Id}.");
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            var cmpType = components.
            if (components.Count == 0 || cmpType != componentType)
            {

            }
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(components.Count.ToString());
            foreach (var component in components)
            {
                sb.AppendLine(component.ToString());
            }
            sb.AppendLine(peripherals.Count.ToString());
            foreach(var peripheral in peripherals)
            {
                sb.AppendLine(peripheral.ToString());
            }
            return sb.ToString();
        }
    }
}
