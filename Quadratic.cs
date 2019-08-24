//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Quadratic.cs" company ="Bridgelabz">
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
    class Quadratic
    {
        public void CalculateRoots()
        {
            //Take a, b and c as input values to find the roots of x. 
            Console.WriteLine("enter the value of a");
            double a = Utility.ReadDouble();
            Console.WriteLine("enter the value of b");
            double b = Utility.ReadDouble();
            Console.WriteLine("Enter the value of c");
            double c = Utility.ReadDouble();
            double delta = b * b - 4 * a * c;
            double root1 = 0.0;
            double root2 = 0.0;
            //Root 1 of x = (-b + sqrt(delta))/(2*a)
            //Root 2 of x = (-b - sqrt(delta))/(2*a) 
            if (delta > 0)
            {
                root1 = (-b + Math.Sqrt(delta)) / 2 * a;
                root2 = (b + Math.Sqrt(delta)) / 2 * a;
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / 2 * a;
            }
            else
            {
                root1 = (-b + Math.Sqrt(delta)) / 2 * a;
                root2 = (b + Math.Sqrt(delta)) / 2 * a;
            }
            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }
    }
}
