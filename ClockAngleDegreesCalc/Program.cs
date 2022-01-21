
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.IO;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Validation;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc.Services;
using ClockAngleDegreesCalc.ClockAngleDegreesCalc;

var Input = new Input();

var LesserAngleDegreesCalcService = new LesserAngleDegreesCalcService();

var Output = new Output();

var InputValidation = new InputValidation();

var ClockAngleDegreesCalculator = new ClockAngleDegreesCalculator(
    LesserAngleDegreesCalcService, Output, Input, InputValidation);

ClockAngleDegreesCalculator.Run();

