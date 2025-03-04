namespace CustomQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new CustomQueue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("Niki");
            myQueue.Enqueue("Kiko");
            myQueue.Enqueue("Mitko");
            myQueue.Enqueue("Pesho");
            myQueue.Enqueue("Merema");
            myQueue.Print();
            var m = myQueue.Dequeue();
            Console.WriteLine($"-------------+---------");
            myQueue.ShiftRight(1);
            myQueue.Print();
            Console.WriteLine($"-------------+---------");
            myQueue.ShiftRight(3);
            myQueue.Print();
            Console.WriteLine($"-------------+---------");
            Console.WriteLine(m);
            var me = myQueue.Peek(3);
            Console.WriteLine($"-------------+---------");
            myQueue.Print();
            Console.WriteLine($"-------------+---------");
            Console.WriteLine(me);
            Console.WriteLine($"-------------+---------");
            myQueue.Clear();
            myQueue.Print();





        }
    }
}
