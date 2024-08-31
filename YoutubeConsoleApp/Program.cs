using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting asynchronous operations...");

        // 1. Calling an asynchronous method
        await PerformAsyncOperations();

        Console.WriteLine("Asynchronous operations completed.");
    }

    // An example asynchronous method
    static async Task PerformAsyncOperations()
    {
        // 2. Performing an asynchronous HTTP request
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/posts";
                Console.WriteLine($"Fetching data from {url}...");

                // Awaiting the async operation
                string result = await httpClient.GetStringAsync(url);

                Console.WriteLine("Data fetched successfully!");
                Console.WriteLine(result.Substring(0, 100) + "..."); // Display first 100 characters
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // 3. Simulating an asynchronous file write operation
        await WriteToFileAsync("output.txt", "Hello, world!");

        Console.WriteLine("File write operation completed.");
    }

    // An example of an asynchronous file write operation
    static async Task WriteToFileAsync(string filePath, string content)
    {
        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
        {
            await writer.WriteLineAsync(content);
        }
    }
}