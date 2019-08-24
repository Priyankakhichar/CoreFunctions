//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Utility.cs" company ="Bridgelabz">
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
    class Utility
    {
        public static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static String ReadString()
        {
            return Console.ReadLine();
        }
    }
}
