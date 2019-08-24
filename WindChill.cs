//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "WindChill.cs" company ="Bridgelabz">
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
    class WindChill
    {
        public void CalculateWindChill()
        {
            Console.WriteLine("Enter the value of temperature t (in Fahrenheit) less than 50 ");
            int t = Utility.ReadInteger();
            Console.WriteLine("Enter the value of wind speed v (in miles per hour) between 120 or less than 3 ");
            int v = Utility.ReadInteger();
            //w = 35.74 + 0.6215 t + (0.4275 t - 35.75) v^0.16
            double windChill = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("windChill is: " + windChill);
        }
    }
}
