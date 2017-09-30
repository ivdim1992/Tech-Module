using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 100; i++)
            {
                int oddNumber = int.Parse(Console.ReadLine());

                if (oddNumber % 2 != 0)
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(oddNumber));
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
            
        }
    }
}
