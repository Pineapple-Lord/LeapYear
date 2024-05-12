public class LeapYearFunctions
{
    OutputData outputData;
    public LeapYearFunctions(OutputData outputData)
    {
        this.outputData = outputData;
    }
    private List<_Year> checkedYears = new List<_Year>();
    private short leapYears = 0;
    
    public void CalculateLeapYears(short upToYear)
    {
        for (short year = 1; year < upToYear+1; year++)
        {
            if(year%4==0){
                checkedYears.Add(new _Year(year, true));
                leapYears++;
            }
            else{
                checkedYears.Add(new _Year(year, false));
            }
        }
    }
    public void outputYears()
    {
        System.Console.WriteLine($"Total Leap Years: {leapYears}");
        outputYearsCSV();
        outputYearsJSON();
    }

    void outputYearsCSV()
    {
        this.outputData.ToCSV(checkedYears);
    }

    void outputYearsJSON()
    {
        this.outputData.ToJSON(checkedYears);
    }
}