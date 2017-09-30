using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            if (multiplyNumber > 10)
            {
                Console.WriteLine("{0} X {1} = {2}",number,multiplyNumber, number * multiplyNumber);
            }
            for (int i = multiplyNumber; i <= 10; i++)
            {               
                int result = number * i;                
                Console.WriteLine("{0} X {1} = {2}",number,i,result);
                    
            }
        }
    }
}
