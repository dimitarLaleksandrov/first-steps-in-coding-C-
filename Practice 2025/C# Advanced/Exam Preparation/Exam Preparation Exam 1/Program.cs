namespace Exam_Preparation_Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            var carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            var swords = new SortedDictionary<string, int> 
            {
                {"Gladius", 0},
                {"Shamshir", 0 },
                {"Katana", 0},
                {"Sabre", 0 },
                {"Broadsword", 0 }
            };
            var allSwords = 0;

            while (steel.Count > 0 && carbon.Count > 0) 
            { 
                var takenSteel = steel.Peek();  
                var takenCarbon = carbon.Peek();
                var sum = takenCarbon + takenSteel;

                if (sum == 70)
                {
                    swords["Gladius"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    allSwords++;
                }
                else if (sum == 80)
                {
                    swords["Shamshir"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    allSwords++;
                }
                else if (sum == 90)
                {
                    swords["Katana"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    allSwords++;
                }
                else if (sum == 110)
                {
                    swords["Sabre"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    allSwords++;
                }
                else if (sum == 150)
                {
                    swords["Broadsword"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    allSwords++;
                }
                else
                {
                    steel.Dequeue();
                    takenCarbon += 5;
                    carbon.Pop();
                    carbon.Push(takenCarbon);
                }

            }

            if (allSwords > 0)
            {
                Console.WriteLine($"You have forged {allSwords} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }
            if (steel.Count == 0)
            {
                Console.WriteLine($"Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            if (carbon.Count == 0)
            {
                Console.WriteLine($"Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }

            foreach( var sword in swords)
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }

        }
    }
}
