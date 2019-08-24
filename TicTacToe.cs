//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "TicTacToe.cs" company ="Bridgelabz">
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
    using System.Threading;
    class TicTacToe
    {
        static int player = 1;
        static char[] arr = {'0', '1', '2', '3', '4', '5', '6', '7' ,'8','9'};
        static int flag = 0;
        static int choice;
        public void TicTacToeFunction()
        {
            do
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance");
                }
                else
                {
                    Console.WriteLine("player 1 chance");
                }
                Board();
                Console.WriteLine("please enter the choice");
                choice = Utility.ReadInteger();
                if (arr[choice] != 'O' && arr[choice] != 'X')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Your Choice number is already exited with " + choice + " " + arr[choice]);
                    Console.WriteLine("board is loading please wait some time...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if(flag == 1)
            {
                Console.WriteLine("player {0} has won "+((player % 2)+1));
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        public static void Board()
        {
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| " + arr[1] + " | " + arr[2] + " | " + arr[3]+" |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| " + arr[4] + " | " + arr[5] + " | " + arr[6] + " |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| " + arr[7] + " | " + arr[8] + " | " + arr[9] + " |");
            Console.WriteLine("|___|___|___|");

        }
        public static int CheckWin()
        {
            // checking row wise
            if(arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            //check verticaly
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            //check diagonalny
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if(arr[1] != '1' && arr[2]!= '2' && arr[3]!='3' && arr[4]!='4' && arr[5]!='5' && arr[6] !='6' && arr[7]!='7'&& arr[8]!='8' && arr[9]!='9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
