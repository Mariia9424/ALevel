using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[N];
        Console.WriteLine($"Enter {N} elements:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Element {i + 1}:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Array elements: ");
        foreach (int element in arr)
        {
            Console.Write(element + "; ");
        }

        Random rnd = new Random();

        for (int i = 0; i < N; i++)
        {
            arr[i] = rnd.Next(1, 27);
        }
        Console.WriteLine();
        Console.Write("Array elements: ");
        foreach (int element in arr)
        {
            Console.Write(element + "; ");
        }
        Console.WriteLine();

        Console.WriteLine("Odd numbers from 1 to 26: ");
        for (int i = 1; i <= 26; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + "; ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Even numbers from 1 to 26: ");
        for (int i = 1; i <= 26; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + "; ");
            }
        }
        Console.Write("Enter the value of N: ");
        if (int.TryParse(Console.ReadLine(), out N) && N > 0)
        {
            int[] evenArray = new int[N];
            int[] oddArray = new int[N];

            char[] evenLetters = new char[N];
            char[] oddLetters = new char[N];

            char[] lettersToUppercase = { 'a', 'e', 'i', 'd', 'h', 'j' };

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int randomValue = random.Next(1, 27);

                if (randomValue % 2 == 0)
                {
                    evenArray[i] = randomValue;
                    evenLetters[i] = (char)('A' + randomValue - 1);
                }
                else
                {
                    oddArray[i] = randomValue;
                    oddLetters[i] = (char)('A' + randomValue - 1);
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (lettersToUppercase.Contains(evenLetters[i]))
                {
                    evenLetters[i] = char.ToUpper(evenLetters[i]);
                }
                if (lettersToUppercase.Contains(oddLetters[i]))
                {
                    oddLetters[i] = char.ToUpper(oddLetters[i]);
                }
            }
            Console.WriteLine("Even Array: [" + string.Join(", ", evenArray) + "]");
            Console.WriteLine("Even Letters: [" + string.Join(", ", evenLetters) + "]");
            Console.WriteLine("Odd Array: [" + string.Join(", ", oddArray) + "]");
            Console.WriteLine("Odd Letters: [" + string.Join(", ", oddLetters) + "]");
        }
        else
        {
            Console.WriteLine("Invalid input for N. Please enter a positive integer.");
        }
    }
}