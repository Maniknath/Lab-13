using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lab13
{
    class RoshamboValue
    {
        public int Index { get; set; }
        public RoshamboValue(int Index)
        {
            this.Index = Index;
        }

        public string GenerateValue()
        {
            List<string> values = new List<string>() { "rock", "paper", "secissors" };
            return values[Index];
        }


    }
}
