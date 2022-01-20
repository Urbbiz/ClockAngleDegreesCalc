namespace ClockAngleDegreesCalc.ClockAngleDegreesCalc.Validation
{
    public interface IInputValidation
    {
        bool IsOnlyNumbersRange0To12(string input);
        bool IsOnlyNumbersRange0To59(string input);
    }
}