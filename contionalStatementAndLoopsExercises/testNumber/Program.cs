using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int count = 0;
            int product = 0;
            bool isBoundary = false;
            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    product += i * j * 3;
                    count++;
                    if (product >= boundary)
                    {
                        isBoundary = true;
                        break;
                    }
                }
                if (isBoundary)
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {product} >= {boundary}");
                    break;
                }
            }

            if (product < boundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {product}");               
            }
        }
    }
}
