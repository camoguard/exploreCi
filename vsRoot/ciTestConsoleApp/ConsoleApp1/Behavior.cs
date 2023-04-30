using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Behavior
    {
        public string ConcatenateThreeStrings(string in1, string in2, string in3)
        {
            var sb = new StringBuilder(in1 + in2 + in3 + "12");
            return sb.ToString();
        }
    }
}
