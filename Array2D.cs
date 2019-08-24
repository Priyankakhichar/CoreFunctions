//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Array2D.cs" company ="Bridgelabz">
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
    class Array2D
    {
        public void readArray()
        {
            Console.WriteLine("please enter the rows");
            int rows = Utility.ReadInteger();
            Console.WriteLine("please enter the cols");
            int cols = Utility.ReadInteger();
            int[,] arr = new int[rows,cols];
            //I/P -> M rows, N Cols, and M * N inputs for 2D Array
            for (int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    Console.WriteLine("enter the value for arr[" + i +","+ j + "]");
                    arr[i,j] = Utility.ReadInteger();
                }
            }
            //reading the values of array
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
