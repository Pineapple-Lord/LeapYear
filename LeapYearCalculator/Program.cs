
short currentYear = 2024;
//currentYear = Convert.ToInt16(DateTime.Now.Year);

OutputData outputData = new OutputData();
LeapYearFunctions leapYearFunctions = new LeapYearFunctions(outputData);

leapYearFunctions.CalculateLeapYears(currentYear);
leapYearFunctions.outputYears();
