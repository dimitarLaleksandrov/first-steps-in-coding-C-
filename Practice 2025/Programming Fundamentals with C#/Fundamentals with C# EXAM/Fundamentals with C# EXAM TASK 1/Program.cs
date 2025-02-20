using System.ComponentModel;

namespace Fundamentals_with_C__EXAM_TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meals = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
 
            var caloriesPerDay = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var numOfMeals = 0;
            const int salad = 350;
            const int soup = 490;
            const int pasta = 680;
            const int steak = 790;

            while(true) 
            {
                if (meals.Count <= 0)
                {
                    break;
                }

                var calories = caloriesPerDay.Peek();
                
                var meal = meals[0];
                
                switch (meal)
                {
                    case "salad":
                        calories -= salad;
                        break;
                    case "soup":
                        calories -= soup;
                        break;
                    case "pasta":
                        calories -= pasta;
                        break;
                    case "steak":
                        calories -= steak;
                        break;

                    default:
                        break;
                }
                if (calories <= 0)
                {
                    caloriesPerDay.Pop();
                    if (caloriesPerDay.Count == 0)
                    {
                        numOfMeals += 1;
                        meals.Remove(meal);
                        break;
                    }
                    var newCalories = caloriesPerDay.Pop();
                    var remainCal = newCalories + calories;
                    if (remainCal <= 0)
                    {
                        break;
                    }
                    caloriesPerDay.Push(remainCal);
                }
                else 
                {
                    caloriesPerDay.Pop();
                    caloriesPerDay.Push(calories);
                }
                numOfMeals += 1;
                meals.Remove(meal);

            }
            if (caloriesPerDay.Count == 0)
            {
                Console.WriteLine($"John ate enough, he had {numOfMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");

            }
            else
            {
                Console.WriteLine($"John had {numOfMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDay)} calories.");

            }




        }
    }
}
