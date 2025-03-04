namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStack = new CustomStack<string>();
            myStack.Push("Niki");
            myStack.Push("Mitko");
            myStack.Push("Kir4o");
            myStack.Push("Nikola");
            myStack.Push("Toshko");
            myStack.Print();
            var m = myStack.Pop();
            Console.WriteLine( m );
            myStack.Print();
            var my =  new Stack<string>();
            my.Clear();
            myStack.Clear();
            myStack.Print();



        }
    }
}
