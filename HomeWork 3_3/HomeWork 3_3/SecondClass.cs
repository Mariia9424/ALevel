namespace HomeWork_3_3
{
    public sealed class SecondClass
    {
        public delegate bool ResultDelegate(int number);

        public ResultDelegate Calc(Func<int, int, int> multiplyDelegate, int param1, int param2)
        {
            int result = multiplyDelegate(param1, param2);

            return (int number) =>
            {
                return Result(result, number);
            };
        }

        public bool Result(int result, int number)
        {
            int remainder = result % number;
            return remainder == 0;
        }
    }
}
