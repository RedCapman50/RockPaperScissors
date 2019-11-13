using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string Player, ComputerPlayer;
            int RandomNess;
            
            bool PlayAgain = true;

            while (PlayAgain)
            {

                int ScorePlayer = 0;
                int ScoreComputer = 0;

                while (ScorePlayer < 3 && ScoreComputer < 3)
                {


                    Console.WriteLine("Choose between ROCK, PAPER or SCISSORS:     ");
                    Player = Console.ReadLine();
                    Player = Player.ToUpper();

                    Random rnd = new Random();

                    RandomNess = rnd.Next(1, 4);

                    switch (RandomNess)
                    {
                        case 1:
                            ComputerPlayer = "ROCK";
                            Console.WriteLine("Computer Chose ROCK");
                            if (Player == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }

                            else if (Player == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                ScorePlayer++;
                            }

                            else if (Player == "SCISSORS")
                            {
                                Console.WriteLine("COMPUTER WINS!!!\n\n");
                                ScoreComputer++;
                            }
                            break;
                        case 2:
                            ComputerPlayer = "PAPER";
                            Console.WriteLine("Computer Chose PAPER");
                            if (Player == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }

                            else if (Player == "ROCK")
                            {
                                Console.WriteLine("Computer WINS!!\n\n");
                                ScoreComputer++;
                            }

                            else if (Player == "SCISSORS")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                ScorePlayer++;
                            }
                            break;
                        case 3:
                            ComputerPlayer = "SCISSORS";
                            Console.WriteLine("Computer Chose SCISSORS");
                            if (Player == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }

                            else if (Player == "ROCK")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                ScorePlayer++;
                            }

                            else if (Player == "PAPER")
                            {
                                Console.WriteLine("Computer WINS!!\n\n");
                                ScoreComputer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Error in Selection");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCOMPUTER:\t{1}", ScorePlayer, ScoreComputer);

                }

                if (ScorePlayer == 3)
                {
                    Console.WriteLine("Player has WON!!");
                }
                else if (ScoreComputer == 3)
                {
                    Console.WriteLine("Cimputer has WON!!");
                }
                else
                {

                }

                Console.WriteLine("Do you wish to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    PlayAgain = true;
                    Console.Clear();
                }

                else if (loop == "n")
                {
                    PlayAgain = false;
                }

                else 
                {
                    
                }
            }
        }
    }
}
