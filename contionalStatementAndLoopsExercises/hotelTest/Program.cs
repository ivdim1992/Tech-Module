﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            if (month == "May" || month == "October")
            {
                priceStudio += 50;
                priceDouble += 65;
                priceSuite += 75;
            }
            else if (month == "June" || month == "September")
            {
                priceStudio += 60;
                priceDouble += 72;
                priceSuite += 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio += 68;
                priceDouble += 77;
                priceSuite += 89;
            }

            if ((month == "May" || month == "October") && nights > 7)
            {
                 priceStudio *= 0.95;
            }
            if ((month == "June" || month == "September") && nights > 14)
            {
                priceStudio *= 0.9;
            }
            if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                priceSuite *= 0.85;
            }
            
            double totalPriceStudio = priceStudio * nights;
            double totalPriceDouble = priceDouble * nights;
            double totalPriceSuite =  priceSuite * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                totalPriceStudio -= priceStudio;
            }

            Console.WriteLine("Studio: {0:f2} lv.",totalPriceStudio);
            Console.WriteLine("Double: {0:f2} lv.", totalPriceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", totalPriceSuite);
        }
    }
}
