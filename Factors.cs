//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Factors.cs" company ="Bridgelabz">
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
    class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("please enter the number for which you want prime factors");
            int num = Utility.ReadInteger();
            for(int i=2; i<=num;)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
