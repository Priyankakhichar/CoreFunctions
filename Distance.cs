//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Distance.cs" company ="Bridgelabz">
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
    class Distance
    {
        public void CalculateDistance()
        {
            Console.WriteLine("Enter the value of x");
            int x = Utility.ReadInteger();
            Console.WriteLine("enter the value of y");
            int y = Utility.ReadInteger();
            double distance = Math.Sqrt(x * x + y * y);

            Console.WriteLine("distance is: " + distance);
        }
    }
}
