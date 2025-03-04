using static System.Net.Mime.MediaTypeNames;

namespace Exercise_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var inputFilePath = new StreamReader(@"../../../../copyMe.png"))
            {
                using(var outputFilePath = new StreamReader(@"../../../../copyMe-copy.png"))
                {

                }
            }
        }
    }
}
