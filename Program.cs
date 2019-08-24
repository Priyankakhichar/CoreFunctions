//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Program.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            ReplaceString rs = new ReplaceString();
            FlipCoin fc = new FlipCoin();
            LeapYear ly = new LeapYear();
            Harmonic harmonic = new Harmonic();
            PowerOfTwo powerOfTwo = new PowerOfTwo();
            Factors factors = new Factors();
            Gambler gambler = new Gambler();
            CouponNumber coupon = new CouponNumber();
            SumOfThree sumOfThree = new SumOfThree();
            Distance distance = new Distance();
            Array2D array = new Array2D();
            StopWatch stopWatch = new StopWatch();
            Quadratic quadratic = new Quadratic();
            WindChill wind = new WindChill();
            Permutation permutation = new Permutation();
            TicTacToe ttt = new TicTacToe();
            Console.WriteLine("1.ReplaceString");
            Console.WriteLine("2.FlipCoin");
            Console.WriteLine("3.LeapYear");
            Console.WriteLine("4.PowerOfTwo");
            Console.WriteLine("5.HarmonicNumber");
            Console.WriteLine("6.PrimeFactors");
            Console.WriteLine("7.Gambler");
            Console.WriteLine("8.Coupon Number");
            Console.WriteLine("9.Array2D");
            Console.WriteLine("10.SumOfThree");
            Console.WriteLine("11.Distance");
            Console.WriteLine("12.StopWatch");
            Console.WriteLine("13.Quadratic");
            Console.WriteLine("14.WindChill");
            Console.WriteLine("15. Permutation");
            Console.WriteLine("16.TicTacToe");
            Console.WriteLine("please enter the programe number which you want to execute");
            int choice = Utility.ReadInteger();
            switch(choice)
            {
                case 1: Console.WriteLine(rs.ReplaceStrings());
                        break;
                case 2: fc.FlipCoins();
                        break;
                case 3: ly.LeapYears();
                        break;
                case 4: powerOfTwo.PowerOf2();
                        break;
                case 5: harmonic.HarmonicNumber();
                        break;
                case 6: factors.PrimeFactors();
                        break;
                case 7: gambler.StartGambler();
                        break;
                case 8: CouponNumber.GenerateCouponNumber();
                        break;
                case 9: array.readArray();
                        break;
                case 10: sumOfThree.GenerateSumOfThree();
                         break;
                case 11: distance.CalculateDistance();
                         break;
                case 12: stopWatch.CalculateElapsedTime();
                         break;
                case 13: quadratic.CalculateRoots();
                         break;
                case 14: wind.CalculateWindChill();
                         break;
                case 15: permutation.StringPermutation();
                         break;
                case 16: ttt.TicTacToeFunction();
                         break;
            }
        }
    }
}
