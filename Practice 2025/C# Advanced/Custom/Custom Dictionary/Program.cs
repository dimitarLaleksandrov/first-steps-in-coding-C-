namespace Custom_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new CustomDictionary<int, string>();
            myDictionary.Add(1, "Mitko");
            myDictionary.Add(1, "4");

            myDictionary.Add(4, "NIki");
            myDictionary.Add(5, "Kiko");
            myDictionary.Add(5, "g");

            myDictionary.Add(16, "To6ko");
            myDictionary.Add(78, "Vesi");
            myDictionary.Print();

        }
    }
}
