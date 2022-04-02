using System;
using System.Collections.Generic;

namespace Problem_3___The_Pianist
{
    class Composers
    {
        public Composers(string piece, string ComposersName, string ComposersKey)
        {
            this.Piece = piece;
            this.ComposersName = ComposersName;
            this.ComposersKey = ComposersKey;
        }
        public string Piece { get; set; }
        public string ComposersName { get; set; }
        public string ComposersKey { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, Composers> composers = new Dictionary<string, Composers>();
            for (int i = 1; i <= numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = pieces[0];
                string composersName = pieces[1];
                string composersKey = pieces[2];
                if (!composers.ContainsKey(piece))
                {
                    Composers newComposer = new Composers(piece, composersName, composersKey);
                    composers.Add(piece, newComposer);
                }
            }
            string commands;
            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] commArg = commands.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = commArg[0];
                if (command == "Add")
                {
                    string piece = commArg[1];
                    string composersName = commArg[2];
                    string composersKey = commArg[3];
                    if (!composers.ContainsKey(piece))
                    {
                        Composers newComposer = new Composers(piece, composersName, composersKey);
                        composers.Add(piece, newComposer);
                        Console.WriteLine($"{piece} by {composersName} in {composersKey} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    string piece = commArg[1];
                    if (composers.ContainsKey(piece))
                    {
                        composers.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string piece = commArg[1];
                    string newKey = commArg[2];
                    if (composers.ContainsKey(piece))
                    {
                        composers[piece].ComposersKey = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }   
            }
            foreach (var composer in composers)
            {
                Console.WriteLine($"{composer.Value.Piece} -> Composer: {composer.Value.ComposersName}, Key: {composer.Value.ComposersKey}");
            }
        }
    }
}
