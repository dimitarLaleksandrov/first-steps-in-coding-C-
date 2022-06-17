using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int salad = 350;
            const int soup = 490;
            const int pasta = 680;
            const int steak = 790;
            string[] inputMeals = Console.ReadLine().Split();
            int[] inputCalories = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> meal = new List<string>();
            List<int> calorie = new List<int>();
            int mealCounter = 0;
            foreach (var food in inputMeals)
            {
                meal.Add(food);
            }
            for (int i = inputCalories.Length -1; i >= 0; i--)
            {
                calorie.Add(inputCalories[i]);
            }
            for (int i = 0; i < inputMeals.Length; i++)
            {
                if (inputMeals[i] == "salad")
                {
                    if (calorie[0] >= salad)
                    {
                        calorie[0] -= salad;                     
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                    else if(calorie[0] < salad)
                    {
                        var calLeft = salad - calorie[0];
                        calorie.Remove(calorie[0]);
                        if (calorie.Count == 0)
                        {
                            meal.Remove(inputMeals[i]);
                            mealCounter++;
                            break;
                        }
                        calorie[0] -= calLeft;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }                   
                }
                else if (inputMeals[i] == "soup")
                {
                    if (calorie[0] >= soup)
                    {
                        calorie[0] -= soup;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                   else if (calorie[0] < soup)
                    {
                        var calLeft = soup - calorie[0];
                        calorie.Remove(calorie[0]);
                        if (calorie.Count == 0)
                        {
                            meal.Remove(inputMeals[i]);
                            mealCounter++;
                            break;
                        }
                        calorie[0] -= calLeft;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                }
                else if (inputMeals[i] == "pasta")
                {
                    if (calorie[0] >= pasta)
                    {
                        calorie[0] -= pasta;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                   else if (calorie[0] < pasta)
                    {
                        var calLeft = pasta - calorie[0];
                        calorie.Remove(calorie[0]);
                        if (calorie.Count == 0)
                        {
                            meal.Remove(inputMeals[i]);
                            mealCounter++;
                            break;
                        }
                        calorie[0] -= calLeft;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                }
                else if (inputMeals[i] == "steak")
                {
                    if (calorie[0] >= steak)
                    {
                        calorie[0] -= steak;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                   else if (calorie[0] < steak)
                    {
                        var calLeft = steak - calorie[0];
                        calorie.Remove(calorie[0]);
                        if (calorie.Count == 0)
                        {
                            meal.Remove(inputMeals[i]);
                            mealCounter++;
                            break;
                        }
                        calorie[0] -= calLeft;
                        meal.Remove(inputMeals[i]);
                        mealCounter++;
                    }
                }
            }
            if (meal.Count == 0)
            {
                Console.WriteLine($"John had {mealCounter} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calorie)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealCounter} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meal)}.");
            }
        }
    }
}
