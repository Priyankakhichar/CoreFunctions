//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "ReplaceString.cs" company ="Bridgelabz">
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
    class ReplaceString
    {
        public string ReplaceStrings()
        {
            string s1 = "Hello <<UserName>>,How are you?";
            string s2 = "<<UserName>>";
            string s3;
            Console.WriteLine("Enter a UserName");
            //reading input from user
            s3 = Console.ReadLine();
            s1 = s1.Replace(s2, s3);
            return s1;
        }
    }
}
