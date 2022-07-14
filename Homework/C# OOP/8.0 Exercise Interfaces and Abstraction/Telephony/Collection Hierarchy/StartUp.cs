using System;
using CollectionHierarchy.Models.Interface;
using CollectionHierarchy.Models;
namespace CollectionHierarchy
{   
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int removeOperations = int.Parse(Console.ReadLine());
            IAddCollection<string> added = new AddCollection<string>();
            IAddRemoveCollection<string> remove = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();
            AddToCall(words, added);
            AddToCall(words, remove);
            AddToCall(words, myList);
            RemoveFromCall(removeOperations, remove);
            RemoveFromCall(removeOperations, myList);
        }
        private static void AddToCall(string[] words, IAddCollection<string> collection)
        {
            foreach (var w in words)
            {
                Console.Write(collection.Add(w) + " ");
            }
            Console.WriteLine();
        }
        private static void RemoveFromCall(int removeOperation, IAddRemoveCollection<string> collection)
        {
            for (int i = 0; i < removeOperation; i++)
            {
                Console.Write(collection.Remove() + " ");
            }
            Console.WriteLine();
        }
    }
}
