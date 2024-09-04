using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting application...");

        try
        {
            // Example of file reading with exception handling
            string filePath = "example.txt";
            string content = await ReadFileAsync(filePath);
            Console.WriteLine($"File content: {content}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Cleaning up resources...");
            // Code to clean up resources, if necessary
        }

        Console.WriteLine("Application completed.");
    }

    // Asynchronous method for reading a file
    static async Task<string> ReadFileAsync(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentException("File path cannot be null or empty", nameof(path));
        }

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }
        catch (ArgumentException ex)
        {
            // Handle specific exception
            Console.WriteLine($"Argument error: {ex.Message}");
            throw; // Re-throwing the exception
        }
    }
}

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }

    public CustomException(string message, Exception innerException) : base(message, innerException) { }
}