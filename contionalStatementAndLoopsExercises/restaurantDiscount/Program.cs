using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            
            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                int priceSmallHall = 2500;

                if (package == "Normal")
                {
                    int priceAfterPackage = priceSmallHall + 500;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.05);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$",pricePerPerson);
                }
                else if (package == "Gold")
                {
                    int priceAfterPackage = priceSmallHall + 750;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.1);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    int priceAfterPackage = priceSmallHall + 1000;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.15);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                int priceTerrace = 5000;

                if (package == "Normal")
                {
                    int priceAfterPackage = priceTerrace + 500;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.05);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    int priceAfterPackage = priceTerrace + 750;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.1);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    int priceAfterPackage = priceTerrace + 1000;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.15);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                int priceGreatHall = 7500;

                if (package == "Normal")
                {
                    int priceAfterPackage = priceGreatHall + 500;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.05);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    int priceAfterPackage = priceGreatHall + 750;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.1);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    int priceAfterPackage = priceGreatHall + 1000;
                    double priceAfterDiscount = priceAfterPackage - (priceAfterPackage * 0.15);
                    double pricePerPerson = priceAfterDiscount / groupSize;
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
