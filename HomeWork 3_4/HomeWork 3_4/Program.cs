using HomeWork_3_4.Delegate;
namespace HomeWork_3_4;

public delegate int CalculateDelegate(int a, int b);
public sealed class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        calculator.CalculateEvent += CalculationHandler;
        calculator.CalculateEvent += CalculationHandler;

        int resultSum = calculator.InvokeCalculation(17, 32);
        int resultSum2 = calculator.InvokeCalculation(49, 28);

        Console.WriteLine("Result Sum: " + resultSum);
        Console.WriteLine("Result Sum: " + resultSum2);
    }

    static void CalculationHandler(int result)
    {
        try
        {
            Console.WriteLine("Calculation Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.ReadLine();
    }
}  