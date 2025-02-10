namespace Programming_Basics_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodKilo = double.Parse(Console.ReadLine());
            int dogFoodEatead = 0;
            int catFoodEatrad = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++) 
            {
                int dogDayFood = int.Parse(Console.ReadLine());
                int catDayFood = int.Parse(Console.ReadLine());
                dogFoodEatead += dogDayFood;
                catFoodEatrad += catDayFood;
                if(i % 3 == 0)
                {
                   biscuits += Math.Abs((dogDayFood + catDayFood) * 0.1);
                }
            }
            int totalFoodEaten = dogFoodEatead + catFoodEatrad;
            double dogProcentFood = Math.Abs(dogFoodEatead / totalFoodEaten);
            double catProcentFood = (catFoodEatrad / totalFoodEaten) * 100;
            double eatedFood = Math.Abs(totalFoodEaten / foodKilo * 100);

            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            Console.WriteLine($"{eatedFood}% of the food has been eaten.");
            Console.WriteLine($"{dogProcentFood:f}% eaten from the dog.");
            Console.WriteLine($"{catProcentFood:f}% eaten from the cat.");





        }
    }
}
