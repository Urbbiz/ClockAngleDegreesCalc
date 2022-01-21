namespace ClockAngleDegreesCalc.ClockAngleDegreesCalc.Services
{

    public class LesserAngleDegreesCalcService : ILesserAngleDegreesCalcService
    {
        public decimal GetLesserAngleDegree(int hour, int minutes)
        {
            decimal AngleDegree = GetDegreeFromHourMinutes(hour, minutes) - GetDegreeFromMinutes(minutes);

            if (AngleDegree < 0)
            {
                AngleDegree = Math.Abs(AngleDegree);
            }

            if (AngleDegree > 180)
            {
                return CalcLesserDegree(AngleDegree);
            }
            else

                return AngleDegree;
        }


        private decimal GetDegreeFromHourMinutes(int hour, int minutes)
        {
            decimal hourDegreeFromMinutes = minutes * 0.5M;

            return (hour * 30) + hourDegreeFromMinutes;
        }

        private decimal GetDegreeFromMinutes(int minutes)
        {
            return minutes * 6;
        }

        private decimal CalcLesserDegree(decimal AngleDegree)
        {
            return 360 - AngleDegree;
        }

    }
}
