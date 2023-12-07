namespace HomeWork_3_3
{
    public sealed class FirstClass
    {
        public delegate void ShowDelegate(bool result);

        public ShowDelegate Show;

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
