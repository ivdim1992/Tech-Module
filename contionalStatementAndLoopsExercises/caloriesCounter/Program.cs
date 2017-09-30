using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 0; i < numberOfIngredients; i++)
            {
                string nameOfIngredient = Console.ReadLine().ToLower();

                if (nameOfIngredient == "cheese")
                {
                    totalCalories += 500;
                }
                else if (nameOfIngredient == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (nameOfIngredient == "salami")
                {
                    totalCalories += 600;
                }
                else if (nameOfIngredient == "pepper")
                {
                    totalCalories += 50;
                }
                else
                {
                    totalCalories += 0;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
