namespace HomeWork11;

public class Multiplication
{
    public static int MultiplyByFiveOnlyNegatives(string num1) 
    {
        if (num1 == "") 
        {
            throw new Exception("string is empty");
        }
        if (!Int32.TryParse(num1, out int result)) 
        {
            throw new Exception("Incorrect input");
        }
        if (result >= 0)
        {
            throw new Exception("You can't multiply positive numbers");
        }

        return result * 5; 
    }
}
