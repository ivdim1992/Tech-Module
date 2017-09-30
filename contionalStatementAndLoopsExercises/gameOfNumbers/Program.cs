using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int magicI = 0;
            int magicJ = 0;
            
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinations++;
                    var sum = i + j;
                    if (sum == magicNumber)
                    {
                        magicI = i;
                        magicJ = j;
                    }
                 
                }
            }
            if (magicI > 0)
            {
                Console.WriteLine($"Number found! {magicI} + {magicJ} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
