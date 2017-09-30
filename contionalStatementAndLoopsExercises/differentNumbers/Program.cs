using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace differentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            if (lastNumber - firstNumber < 4)
            {
                Console.WriteLine("No");
            }

            for (int firstDigit = firstNumber; firstDigit < lastNumber; firstDigit++)
            {
                for (int secondDigit = firstNumber; secondDigit <= lastNumber; secondDigit++)
                {
                    for (int thirdDigit = firstNumber; thirdDigit <= lastNumber; thirdDigit++)
                    {
                        for (int fourthDigit = firstNumber; fourthDigit <= lastNumber; fourthDigit++)
                        {
                            for (int fifthDigit = firstNumber; fifthDigit <= lastNumber; fifthDigit++)
                            {
                                if (firstDigit < secondDigit && secondDigit < thirdDigit && thirdDigit < fourthDigit && fourthDigit < fifthDigit)
                                {
                                    Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit} {fourthDigit} {fifthDigit}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
