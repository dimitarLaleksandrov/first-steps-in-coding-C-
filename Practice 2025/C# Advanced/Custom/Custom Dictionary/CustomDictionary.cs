using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Custom_Dictionary
{
    public class CustomDictionary<TKey, TValue>
    {
        public CustomDictionary()
        {
            count = 0;
            this.Keys = new TKey[initCapacity];
            this.Values = new TValue[initCapacity];
        }

        public TKey[] Keys{ get; set; }
        public TValue[] Values { get; set; }

        private const int initCapacity = 4;

        public int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(TKey key, TValue value) 
        {
            if (IsKeyUnique(this.Keys, key))
            {
                if (this.Keys.Length == this.count)
                {
                    var nextKey =  new TKey[this.Keys.Length + 1];
                    var nextValue = new TValue[this.Values.Length + 1];
                    for (int i = 0; i < this.Values.Length; i++)
                    {
                        nextKey[i] = this.Keys[i];
                        nextValue[i] = this.Values[i];
                    }
                    this.Keys = nextKey;
                    this.Values = nextValue;
                }
                this.Keys[this.count] = key;
                this.Values[this.count] = value;
                count++;
            }
            else
            {
                Console.WriteLine($"The given key exists");
                
            }          
        }
        public void Print()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.WriteLine($"Key {this.Keys[i]} - Value {this.Values[i]}");
            }
        }

        private bool IsKeyUnique(TKey[] keys, TKey value)
        {
            var IsUnique = true;
            foreach (var key in keys) 
            {
                if (key.Equals(value))
                {
                    IsUnique = false;
                    break;
                }
            }
            return IsUnique;
        }
        
    }
}
