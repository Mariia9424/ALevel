namespace HomeWork_3_1
{
    class Program
    {
        static void Main()
        {

            var customCollection = new CustomCollection<string>();

            customCollection.Add("Scarf");
            customCollection.Add("Hat");
            customCollection.Add("Coat");
            customCollection.Add("Gloves");


            Console.WriteLine("Original Collection:");
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }

            customCollection.Sort();

            Console.WriteLine("\nSorted Collection:");
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }
            customCollection.SetDefaultAt(1, "Muff");
            customCollection.Sort(); 

            Console.WriteLine("\nCollection with Muff:");
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }

           Console.WriteLine("\nCollection items count: " + customCollection.Count());

        }
    }
}