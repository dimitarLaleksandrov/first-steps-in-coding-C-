using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList(Random rnd)
        {
            this.Rnd = rnd;
        }

        public Random Rnd { get => rnd; set => rnd = value; }

        public string RemoveRandomElement()
        {
            string str = string.Empty;
            int index = Rnd.Next(0, this.Count);
            str = this[index];
            this.RemoveAt(index);
            return str;
        }

        private void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
