using System.Runtime.ConstrainedExecution;

Random rnd = new Random();

int[] A = new int[20];

for (int i = 1; i <=888 ; i++)
{
    A[i] = rnd.Next();

    Console.WriteLine(A[i]);
    
}

int[] B = { rnd.Next() };
int temp;
for (int i = 1; i < B.Length - 1; i++)
{
    for (int j = i + 1; j < B.Length; j++)
    {
        if (B[i] > B[j])
        {
            temp = B[i];
            B[i] = B[j];
            B[j] = temp;
        }
    }
}
Console.WriteLine("Виведення вiдсортованого масиву");
for (int i = 1; i < B.Length; i++)
{
    Console.WriteLine(B[i]);
}