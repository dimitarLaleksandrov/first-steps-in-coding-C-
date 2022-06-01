using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class AddVAT
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat = x => x * 1.20m;
            decimal[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            decimal[] num = nums.Select(addVat).ToArray();
            Array.ForEach(num, x => Console.WriteLine("{0:f2}", x));
        }
    }
}
