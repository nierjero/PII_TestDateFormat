namespace TestDateFormat;

public class DateFormatterTests
{

    [Test]
    public void FechaVacia()
    {
        string input = "";
        string expected = "";
        string check =  DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, check );
        

    }

    [Test]
    public void FechaInvalida()
    {
        string input = "1111-11-11";
        string expected = "";
        string check =  DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, check );
    }

    [Test]
    public void FechaValida()
    
    {
        string input = "11/11/1111";
        string expected = "1111-11-11";
        string check =  DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, check );
    } 
    

}