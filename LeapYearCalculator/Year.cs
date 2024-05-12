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
        return $"{Year},{(LeapYear ? "yes" : "no")}";
    }
}