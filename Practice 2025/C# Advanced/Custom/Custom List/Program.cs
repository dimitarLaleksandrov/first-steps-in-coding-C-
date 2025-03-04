namespace Custom_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(4);
            
        }
    }
}
