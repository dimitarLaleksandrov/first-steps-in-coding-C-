namespace Open___Closed
{
    internal class Program
    {
        //open for extension and closed for modification
        public abstract class Animal 
        {
            public string Name { get; set; }
            public int NumVisitsToVet { get; set; }
        }

        public class Dog : Animal
        {
            // public string Name { get; set; }
            // public int NumVisitsToVet { get; set; }
        }
        public class Cat : Animal
        {
            // public string Name { get; set; }
            // public int NumVisitsToVet { get; set; }
        }
        //we are changing obg[] to the new class Animals
        public class VetVisits 
        {
            public int CountVetVisits(Animal[] animals)
            {
                var vetCounts = 0;
                foreach (var animal in animals) 
                {
                    //if (animal is Cat)
                    //{
                    //vetCounts += ((Cat)animal).NumVisitsToVet;
                    //}
                    // else 
                    //{
                    //vetCounts += ((Dog)animal).NumVisitsToVet;

                    //}
                    vetCounts += animal.NumVisitsToVet;
                }
                return vetCounts;
            }      
        }



        static void Main(string[] args)
        {

        }
    }
}
