//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "SumOfThree.cs" company ="Bridgelabz">
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
    class SumOfThree
    {
        //N number of integer, and N integer input array 
        public void GenerateSumOfThree()
        {
            Console.WriteLine("please enter the number of elements that you want to take in array");
            int num = Utility.ReadInteger();
            int[] arr = new int[num];
            for(int i=0; i< arr.Length; i++)
            {
                Console.WriteLine("enter the value of arr[" + i + "]");
                arr[i] = Utility.ReadInteger();
            }
            Console.WriteLine("combitions of distinct three elements");
            for(int i=0; i< arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if(arr[i] != arr[k])
                            {
                                if (arr[i] + arr[j] + arr[k] == 0)
                                {
                                    Console.Write("arr[" + i + "] + arr[" + j + "] +  arr[" + k + "] : ");
                                    Console.WriteLine(arr[i] + arr[j] + arr[k]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
