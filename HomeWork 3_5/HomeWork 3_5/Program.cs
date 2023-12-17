namespace HomeWork_3_5
{
    public sealed class Program
    {
        public static async Task WriteLineAsync()
        {
            string helloText = await ReadFromFileAsync("Hello.txt");
            string worldText = await ReadFromFileAsync("World.txt");

            string result = ConcatenateTextAsync(helloText, worldText).Result;

            Console.WriteLine(result);
        }
        static async Task<string> ReadFromFileAsync(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                return await reader.ReadToEndAsync();
            }
        }
        static async Task<string> ConcatenateTextAsync(string textHello, string textWorld)
        {
            Task<string> taskHello = ExtractTextAsync(textHello);
            Task<string> taskWorld = ExtractTextAsync(textWorld);

            await Task.WhenAll(taskHello, taskWorld);

            return taskHello.Result + taskWorld.Result;
        }
        static async Task<string> ExtractTextAsync(string text)
        {
            await Task.Delay(1000);

            return text;
        }
    }
}