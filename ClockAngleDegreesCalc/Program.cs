using ClockAngleDegreesCalc.ClockAngleDegreesCalc.IO;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Validation;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Services;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Helper;

var Input = new Input();

var InputValidation = new InputValidation();

var LesserAngleDegreesCalcService = new LesserAngleDegreesCalcService();

string? inputStringHour;

string? inputStringMinutes;

int hour;

int minutes;

Console.WriteLine(Message.welcome);

do
{
    Console.WriteLine(Message.hoursInput);

    inputStringHour = Input.GetInputString();

    if (InputValidation.IsOnlyNumbersRange0To12(inputStringHour) == false)
    {
        Console.WriteLine(Message.hoursValidation);
    }

} while(InputValidation.IsOnlyNumbersRange0To12(inputStringHour) == false);
do
{
    Console.WriteLine(Message.minutesInput);

    inputStringMinutes = Input.GetInputString();

    if (InputValidation.IsOnlyNumbersRange0To59(inputStringMinutes) == false)
    {
        Console.WriteLine(Message.minutesValidation);
    }

} while (InputValidation.IsOnlyNumbersRange0To59(inputStringMinutes) == false);

  Int32.TryParse(inputStringHour, out hour);

  Int32.TryParse(inputStringMinutes, out minutes);

decimal lesserAngle = LesserAngleDegreesCalcService.GetLesserAngleDegree(hour, minutes);

Console.WriteLine(Message.finalAnswer + lesserAngle);
