namespace HomeWork11;

internal class Program
{
    static void Main(string[] args)
    {
        
        string incorrectInput = "sd64s6df ";
        string positive = "89";
        string negative = "-20";

        Check(incorrectInput);
        Check(positive);
        Check(negative);
    }

    public static void Check(string num) 
    {
        try
        {
            var result = Multiplication.MultiplyByFiveOnlyNegatives(num);
            Console.WriteLine("result = " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
