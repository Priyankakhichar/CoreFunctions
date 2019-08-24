//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "StopWatch.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Threading;
    using System.Collections.Generic;
    using System.Text;
    class StopWatch
    {
        public void CalculateElapsedTime()
        {
            //Thread t = Thread.CurrentThread;
            DateTime start = DateTime.Now;
            Thread.Sleep(1200);
            DateTime end = DateTime.Now;
            TimeSpan elapsedTime = end - start;
            Console.WriteLine("elapsed time is: " + elapsedTime);
        }
    }
}
