namespace HomeWork_3_3
{
    public sealed class Program
    {
        static void Main()
        {
            FirstClass class1 = new FirstClass();
            SecondClass class2 = new SecondClass();

            FirstClass.ShowDelegate showDelegate = result => Console.WriteLine($"Result: {result}");

            class1.Show = showDelegate;

            SecondClass.ResultDelegate resultDelegate = class2.Calc(class1.Multiply, 5, 2);

            class1.Show(resultDelegate(10));
        }
    }
}