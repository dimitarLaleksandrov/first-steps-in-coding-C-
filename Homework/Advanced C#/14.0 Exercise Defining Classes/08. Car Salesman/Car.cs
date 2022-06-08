using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Car_Salesman
{
    internal class Car
    {
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
    }
}
