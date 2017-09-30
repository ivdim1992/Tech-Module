using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            if (startNumber > endNumber)
            {
                for (int i = endNumber; i <= startNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
