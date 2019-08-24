//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Permutation.cs" company ="Bridgelabz">
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
    class Permutation
    {
        public void StringPermutation()
        {
            Console.WriteLine("enter the string for permutation");
            string str = Utility.ReadString();
            int n = str.Length;
            Permute(str, 0, n - 1);
        }
        private static void Permute(String str, int l, int r)
        {
            // l is start index , r is end index
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    Permute(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }
    public static String Swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
