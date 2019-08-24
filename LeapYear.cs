//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "LeapYear.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class LeapYear
    {
        public void LeapYears()
        {
            Console.WriteLine("please enter the year");
            int year = Utility.ReadInteger();
            int i = year;
            int count = 0;
            while(i != 0)
            {
                count++;
                i = i / 10;
            }
            if(count == 4)
            {
                if(year % 400 == 0 && year % 100 ==0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else if(year % 100 !=0 && year % 4 == 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("please enter the valid year");
            }
        }
    }
}
