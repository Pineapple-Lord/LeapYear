namespace LeapYearTests;

public class YearTests
{
    [Fact]
    public void CorrectLeapYear()
    {
        short year = 2000;
        Assert.Equal(0, year%4);
    }
    [Fact]
    public void InCorrectLeapYear()
    {
        short year = 1999;
        Assert.NotEqual(0, year%4);
    }
    [Fact]
    public void YearString()
    {
        _Year year = new _Year(4, true);
        Assert.Equal("4,Yes", year.ToString());
    }
}

public class _Year{
    public _Year(short year, bool leap)
    {
        this.Year = year;
        this.LeapYear = leap;
    }
    public short Year { get; set; }
    public bool LeapYear { get; set; }
    public override string ToString()//overwrite tostring function for CSV output
    {
        return $"{Year},{(LeapYear ? "Yes" : "No")}";
    }
}