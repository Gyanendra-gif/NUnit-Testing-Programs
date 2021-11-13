﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitProgram
{
    class DayOfWeek
    {
        public void Day()
        {
            Console.WriteLine("Enter the Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Day is " + dayOfWeek(day, month, year));
        }
        public static int dayOfWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            Console.WriteLine("Here the Date is:" +d0);
            return d0;
        }
    }
}
