using System.IO;

namespace LeapYearTests;

public class FileTests
{
    string strPath = Environment.GetFolderPath(
                         Environment.SpecialFolder.DesktopDirectory);
   
   [Fact]
   public void CreateFile()
   {
    string filePath = Path.Combine(strPath, "test.txt");

    File.WriteAllText(filePath, "This is a test");

    Assert.True(File.Exists(filePath));
   }
   [Fact]
   public void DeleteFile()
   {
    string filePath = Path.Combine(strPath, "test.txt");

    File.WriteAllText(filePath, "This is a test");

    File.Delete(filePath);

    Assert.True(!File.Exists(filePath));
   }
}