//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "FlipCoin.cs" company ="Bridgelabz">
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
    class FlipCoin
    {
        public void FlipCoins()
        {
            {
                Random random = new Random();
                int flipTime;
                int headCount = 0;
                int tailCount = 0;
                Console.WriteLine("please enter the number for flipCoin");
                flipTime = Utility.ReadInteger();
                for (int i = 1; i <= flipTime; i++)
                {
                    if (random.NextDouble() > 0.5)
                    {
                        headCount++;
                        Console.WriteLine(random.NextDouble());
                    }
                    else
                    {
                        tailCount++;
                    }
                }
                double headPercent = (double)headCount/ flipTime * 100;
                double tailPercent = (double)tailCount/ flipTime * 100;
                Console.WriteLine("HeadPercent is: " + headPercent);
                Console.WriteLine("tailPercent is: " + tailPercent);
            }
        }
    }
}
