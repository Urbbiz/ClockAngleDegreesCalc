using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleDegreesCalc.ClockAngleDegreesCalc.IO
{
    public class Input : IInput
    {
        public string? GetInputString()
        {
            string? inputString = Console.ReadLine();
            return inputString;
        }
    }
}
