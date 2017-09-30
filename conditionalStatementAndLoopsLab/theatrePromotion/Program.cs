using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfPerson = int.Parse(Console.ReadLine());
            int price = 0;
            if (typeOfDay == "Weekday")
            {
                if (ageOfPerson >= 0 && ageOfPerson <= 18)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 64 && ageOfPerson <= 122)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (ageOfPerson >= 0 && ageOfPerson <= 18)
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 64 && ageOfPerson <= 122)
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (ageOfPerson >= 0 && ageOfPerson <= 18)
                {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (ageOfPerson > 64 && ageOfPerson <= 122)
                {
                    price = 10;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }         
        }
    }
}
