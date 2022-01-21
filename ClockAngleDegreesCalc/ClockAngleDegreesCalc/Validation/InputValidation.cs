using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.IO;

namespace ClockAngleDegreesCalc.ClockAngleDegreesCalc.Validation
{
    public class InputValidation : IInputValidation
    {
        public bool IsOnlyNumbersRange0To12(string? input)
        {
            return Regex.IsMatch(input ?? "", "^^(1[0-2]|[0-9])$");
        }

        public bool IsOnlyNumbersRange0To59(string? input)
        {
            return Regex.IsMatch(input ?? "", "^^([1-5]?[0-9])$");
        }
    }
}
