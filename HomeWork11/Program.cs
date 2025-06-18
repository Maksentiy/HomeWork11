namespace HomeWork11;

internal class Program
{
    static void Main(string[] args)
    {
        string nullString = null;
        string emptyString = "";
        string incorrectInput = "sd64s6df ";
        string num1 = "89";

        Check(nullString);
        Check(emptyString);
        Check(incorrectInput);
        Check(num1);
    }

    public static void Check(string num) 
    {
        try
        {
            var result = Multiplication.MultiplyByFive(num);
            Console.WriteLine("result = " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
