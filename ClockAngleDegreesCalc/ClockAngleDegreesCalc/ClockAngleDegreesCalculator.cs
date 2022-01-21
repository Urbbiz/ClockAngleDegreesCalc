using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Helper;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.IO;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Services;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Validation;

namespace ClockAngleDegreesCalc.ClockAngleDegreesCalc
{
    public class ClockAngleDegreesCalculator
    {
        private readonly ILesserAngleDegreesCalcService _lesserAngleDegreesCalcService;

        private readonly IOutput _output;

        private readonly IInput _input;

        private readonly IInputValidation _inputValidation;

        public ClockAngleDegreesCalculator(ILesserAngleDegreesCalcService lesserAngleDegreesCalcService, IOutput output,
        IInput input, IInputValidation inputValidation)
        {
            _lesserAngleDegreesCalcService = lesserAngleDegreesCalcService;
            _output = output;
            _input = input;
            _inputValidation = inputValidation;
        }

        public void Run()
        {
            string? inputStringHour;

            string? inputStringMinutes;

            int hour;

            int minutes;

            _output.GetOutputMessage(Message.Welcome);

            do
            {
                _output.GetOutputMessage(Message.HoursInput);

                inputStringHour = _input.GetInputString();

                if (_inputValidation.IsOnlyNumbersRange0To12(inputStringHour) == false)
                {
                    _output.GetOutputMessage(Message.HoursValidation);
                }

            } while (_inputValidation.IsOnlyNumbersRange0To12(inputStringHour) == false);
            do
            {
                _output.GetOutputMessage(Message.MinutesInput);

                inputStringMinutes = _input.GetInputString();

                if (_inputValidation.IsOnlyNumbersRange0To59(inputStringMinutes) == false)
                {
                    _output.GetOutputMessage(Message.MinutesValidation);
                }

            } while (_inputValidation.IsOnlyNumbersRange0To59(inputStringMinutes) == false);

            hour = Int32.Parse(inputStringHour);

            minutes = Int32.Parse(inputStringMinutes);

            decimal lesserAngle = _lesserAngleDegreesCalcService.GetLesserAngleDegree(hour, minutes);

            _output.GetOutputMessage(Message.FinalAnswer + lesserAngle);


        }
    }


    
}
