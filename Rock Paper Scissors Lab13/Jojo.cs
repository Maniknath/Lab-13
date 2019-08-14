using System;

namespace Rock_Paper_Scissors_Lab13
{
    class Jojo : Player
    {
        Random rand;
        public Jojo(Random rand) : base("Jojo")
        {
            this.rand = rand;
        }


        public Random Rando { get; set; }

        public override string GenerateRoshambo()
        {
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
