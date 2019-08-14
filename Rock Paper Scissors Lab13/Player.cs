namespace Rock_Paper_Scissors_Lab13
{
    abstract class Player
    {
        public string Name { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GenerateRoshambo();
        


    }
}
