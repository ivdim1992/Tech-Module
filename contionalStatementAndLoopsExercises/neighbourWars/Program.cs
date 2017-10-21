using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    round++;
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");                  
                }
                else
                {
                    round++;
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }            

                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
                
            }
            else if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
                
            }

        }
    }
}
