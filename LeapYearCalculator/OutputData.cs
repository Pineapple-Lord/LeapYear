
using System.Text.Json;
public class OutputData
{
    string strPath = Environment.GetFolderPath(
                         Environment.SpecialFolder.DesktopDirectory);
    public void ToCSV(List<_Year> years)
    {
        string CSVPath = Path.Combine(strPath, "leapYears.csv");
        if(File.Exists(CSVPath)) //delete file if exists
        {
            File.Delete(CSVPath);
        }
        //Create file
        using (StreamWriter sw = File.CreateText(CSVPath))
        {
            sw.WriteLine("Year,LeapYear");
            foreach (var year in years)
            {    
                sw.WriteLine(year.ToString());
            }
        }	
    }
    public void ToJSON(List<_Year> years)
    {
        string JSONPath = Path.Combine(strPath, "leapYears.json");
        if(File.Exists(JSONPath)) //delete file if exists
        {
            File.Delete(JSONPath);
        }
        //create file
        using (StreamWriter sw = File.CreateText(JSONPath))
        {
            var json = JsonSerializer.Serialize(years, new JsonSerializerOptions { WriteIndented = true });
            sw.Write(json);
        }
    }
}