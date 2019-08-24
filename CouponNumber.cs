//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "CouponNumber.cs" company ="Bridgelabz">
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
    class CouponNumber
    {
        public static void GenerateCouponNumber()
        {
            Console.WriteLine("How many Coupon Number you want to generate");
            int num = Utility.ReadInteger();
            Random random = new Random();
            for(int i=1; i<= num; i++)
            {
                int coupon = random.Next(1,100) * 1000 * i;
                Console.WriteLine(coupon);
            }
        }
    }
}
