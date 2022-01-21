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
