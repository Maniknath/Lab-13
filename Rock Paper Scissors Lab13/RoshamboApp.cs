using System;

namespace Rock_Paper_Scissors_Lab13
{
    class RoshamboApp
    {
        public HumanPlayer player1;

        public Player player2;

        public Mojo {get; set;}


    public RoshamboApp()
    {
        Console.WriteLine("Enter your name: ");
        string userInput = Console.ReadLine();
        player1 = new HumanPlayer(userInput);

    }


}
}
