//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "PowerOfTwo.cs" company ="Bridgelabz">
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
    class PowerOfTwo
    {
        public void PowerOf2()
        {
            Console.WriteLine("please enter the number");
            int pow = Utility.ReadInteger();
            for(int i=1; i<=pow; i++)
            {
                Console.WriteLine((int)Math.Pow(2, i));
            }
        }
    }
}
