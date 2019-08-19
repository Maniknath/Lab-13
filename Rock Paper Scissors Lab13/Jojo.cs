using System;

namespace Rock_Paper_Scissors_Lab13
{
    class Jojo : Player
    {
        Random rand;
        public Random Rando { get; set; }
        public Jojo(string Name, Random rand) : base(Name)
        {
            this.Rando = rand;
        }



        public override string GenerateRoshambo()
        {
            rand = new Random();
            int random = rand.Next(0, 3);

            RoshamboValue value = new RoshamboValue(random);
            return value.GenerateValue();

            //switch (random)
            //{
            //    case 0:
            //        return Roshambo.Rock.ToString();
            //        break;
            //    case 1:
            //        return Roshambo.Paper;
            //        break;
            //    case 2:
            //        return Roshambo.Scissors;
            //        break;
            //    default:
            //        return Roshambo.Rock;
            //        break;
            //}


        }

    }
}
