class Program
{
    static void Main(string[] args)
    {
        Gift gift = new Gift();

        gift.AddSweet(new Chocolate("Milk Chocolate", 50, 30, 40));
        gift.AddSweet(new Candy("Lollipop", 10, 20, "Cherry"));
        gift.AddSweet(new Cookie("Chocolate Chip Cookie", 30, 15, "Chocolate"));

        Console.WriteLine("Total Weight of Gift: " + gift.GetTotalWeight() + "g");

        Console.WriteLine("\nGift Contents (Unsorted):");
        gift.DisplayContents();

        gift.SortBySugarContent();
        Console.WriteLine("\nGift Contents (Sorted by Sugar Content):");
        gift.DisplayContents();

        double searchSugarContent = 30;
        Sweet foundSweet = gift.FindSweetBySugarContent(searchSugarContent);
        if (foundSweet != null)
        {
            Console.WriteLine($"\nFound Sweet with {searchSugarContent}g sugar content: {foundSweet.GetDescription()}");
        }
        else
        {
            Console.WriteLine($"\nNo Sweet with {searchSugarContent}g sugar content found.");
        }
    }
}