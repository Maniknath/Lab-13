using System;

namespace Rock_Paper_Scissors_Lab13
{
    class RoshamboApp
    {
        Random rando = new Random();

        public HumanPlayer player1;
        public Player player2;

        public int player1Wins { get; set; }
        public int player2Wins { get; set; }


        public RoshamboApp()
        {
            Console.WriteLine("What is your name: ");
            string userInput = Console.ReadLine();
            player1 = new HumanPlayer(userInput);
            TakePlayer2();
            //player2 = new Player(userInput);
            while (ContinuePlay()== true)
            {
                TakePlayer2();
            }
        }
        public bool ContinuePlay()
        {
            bool play = true;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Play again? (y/n): ");
                string playContinue = Console.ReadLine().ToLower().Trim();

                if (playContinue == "n" || playContinue == "no")
                {
                    return false;
                }
                else
                {
                    //Console.WriteLine("Thanks");
                    return true;
                }

            }
        }

        public void TakePlayer2()
        {
            Console.WriteLine($"Ok, {player1.Name}. Who do you want to plat?");
            Console.WriteLine("1: Jojo");
            Console.WriteLine("2: Mojo");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "jojo" || input == "1")
            {
                player2 = new Jojo("jojo", rando);
                Winner(player1, player2);
            }
            else if (input == "mojo" || input == "2")
            {
                player2 = new Mojo("Rock");
                Winner(player1, player2);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }



        public void PrintResult(Player isWinner, string player1Throw, string player2Throw)
        {
            if (player1Throw == player2Throw)
            {
                Console.WriteLine($"{player1.Name} thrpw {player1Throw} {player2.Name} throw. {player2Throw}");
                Console.WriteLine("Its a tie!");
                Console.WriteLine($"{player1.Name}'s wins: {player1Wins}, Opponent wins: {player2Wins}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{player1.Name} throw {player1Throw} {player2.Name} throw {player2Throw}");
                Console.WriteLine($"{isWinner.Name} is the winner!");
                Console.WriteLine($"{player1.Name}'s wins: {player1Wins}, Opponent wins: {player2Wins}");
            }
        }




        public void Winner(Player one, Player two)
        {
            Player isWinner = null;

            string player1Throw = one.GenerateRoshambo();
            string player2Throw = two.GenerateRoshambo();

            if (player1Throw == player2Throw)
            {
                PrintResult(isWinner, player1Throw, player2Throw);
            }

            else
            {
                if (player1Throw == "rock")
                {
                    if (player2Throw == "scissors")
                    {
                        isWinner = one;
                        player1Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);

                    }
                    else
                    {
                        isWinner = two;
                        player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);

                    }

                }
                else if (player1Throw == "paper")
                {
                    if (player2Throw == "rock")
                    {
                        isWinner = one;
                        player1Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);

                    }
                }
                else if (player1Throw == "scissors")
                {
                    if (player2Throw == "paper")
                    {
                        isWinner = one;
                        player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }

                }

            }
        }

    }
}

