class Program
{
    static void Main(string[] args)
    {
        // 1. List<T> Example
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        fruits.Add("Date");
        fruits.Remove("Banana");

        Console.WriteLine("List of Fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 2. Dictionary<TKey, TValue> Example
        Dictionary<int, string> studentDictionary = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

        Console.WriteLine("\nStudent with ID 2: " + studentDictionary[2]);

        // 3. HashSet<T> Example
        HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 2, 1 };
        uniqueNumbers.Add(4);

        Console.WriteLine("\nUnique Numbers:");
        foreach (var number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }

        // 4. Queue<T> Example
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("\nQueue Dequeue: " + queue.Dequeue()); // Removes "First"

        // 5. Stack<T> Example
        Stack<string> stack = new Stack<string>();
        stack.Push("Bottom");
        stack.Push("Middle");
        stack.Push("Top");

        Console.WriteLine("\nStack Pop: " + stack.Pop()); // Removes "Top"

        // 6. Generic Method Example
        Console.WriteLine("\nGeneric Method Example:");
        PrintItems(fruits);
        PrintItems(uniqueNumbers);
    }

    // Generic Method to print any collection
    static void PrintItems<T>(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
