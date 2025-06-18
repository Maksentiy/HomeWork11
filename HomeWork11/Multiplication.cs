namespace HomeWork11;

public class Multiplication
{
    public static int MultiplyByFive(string num1) 
    {
        if (num1 == null) 
        {
            throw new Exception("num1 = null");
        }
        if (num1 == "") 
        {
            throw new Exception("string is empty");
        }
        if (!Int32.TryParse(num1, out int result)) 
        {
            throw new Exception("Incorrect input");
        }


        return result * 5; 
    }
}
