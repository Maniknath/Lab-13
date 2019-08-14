using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lab13
{
    class Mojo : Player
    {
        public Mojo(string Name) : base(Name)
        {

        }

        public override string GenerateRoshambo()
        {
            RoshamboValue value = new RoshamboValue(0);

            return value.GenerateValue();
        }
    }
}
