namespace HomeWork_3_4.Delegate
{
    public sealed class Calculator
    {
        public delegate void CalculateEventHandler(int result);

        public event CalculateEventHandler CalculateEvent;

        public int InvokeCalculation(int a, int b)
        {
            int result = Calculate(a, b);

            CalculateEvent?.Invoke(result);

            return result;
        }

        private int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}