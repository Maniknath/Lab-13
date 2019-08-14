using System;

namespace Rock_Paper_Scissors_Lab13
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string Name) : base(Name)
        {
            ;
        }

        public override string GenerateRoshambo()
        {
            Console.WriteLine(Name + ": throw rock, paper, or scissors?");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "rock")
            {
                RoshamboValue value = new RoshamboValue(0);
                return input.ToString();
            }

            if (input == "paper")
            {
                RoshamboValue value = new RoshamboValue(1);
                return input.ToString();
            }

            else
            {
                RoshamboValue value = new RoshamboValue(2);
                return input.ToString();
            }



        }


    }
}
