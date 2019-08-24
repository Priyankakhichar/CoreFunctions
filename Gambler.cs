//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Gambler.cs" company ="Bridgelabz">
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
    class Gambler
    {
        public void StartGambler()
        {
            Random random = new Random();
            //take input for $Stake, $Goal and Number of times 
            Console.WriteLine("plaese enter the money");
            int money = Utility.ReadInteger();
            int stack = money;
            Console.WriteLine("plaese enter the goal");
            int goal = Utility.ReadInteger();
            Console.WriteLine("plaese enter the number of play times");
            int times = Utility.ReadInteger();
            int winCount = 0;
            //iterate the loop for Given number of times.
            for (int i = 1; i<= times; i++)
            {
                //Play till the gambler is broke or has won
                while ( stack > 0 && stack <goal)
                {
                    if(random.NextDouble() >0.5)
                    {
                        stack++;
                    }
                    else
                    {
                        stack--;
                    }
                }
                if(stack==goal)
                {
                    winCount++;
                }
                stack = money;
            }
            int lossCount = times - winCount;
            double winPercent = (double)winCount / times * 100;
            double lossPercent = (double)lossCount / times * 100;
            Console.WriteLine("number of wins: " + winCount);
            Console.WriteLine("winPercent is: " + winPercent);
            Console.WriteLine("lossPercent is: " + lossPercent);
        }
    }
}
