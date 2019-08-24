//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Harmonic.cs" company ="Bridgelabz">
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
    class Harmonic
    {
        public void HarmonicNumber()
        {
            Console.WriteLine("please enter the number");
            int num = Utility.ReadInteger();
            double last = 0;
            for(int i=1; i<=num; i++)
            {
                last = last + (double)1 / i;
            }
            Console.WriteLine("nth harmonic number is " + last);
        }
    }
}
