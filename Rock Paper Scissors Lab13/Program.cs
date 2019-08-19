using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors game");

            //// Mojo m = new Player();
            //Console.WriteLine("What is your name?");
            //string input = Console.ReadLine();
            //Player human = new HumanPlayer(input);
            //Console.WriteLine(human.Name);

            //Console.WriteLine();
            //Player m = new Mojo("");


            RoshamboApp game = new RoshamboApp();

            Console.ReadKey();
        }
    }
}
