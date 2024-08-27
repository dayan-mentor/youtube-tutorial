class Program
{
    // Main method: the entry point of the program
    static void Main(string[] args)
    {
        // Variables and Data Types
        int age = 38; // Integer variable
        double salary = 50000.50; // Double variable (floating-point number)
        string name = "John Doe"; // String variable
        bool isEmployed = true; // Boolean variable

        // Output variables to the console
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: $" + salary);
        Console.WriteLine("Employed: " + isEmployed);

        // Basic Operations
        int a = 10;
        int b = 20;
        int sum = a + b; // Addition
        int product = a * b; // Multiplication
        int average = b / a; // Division

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Average: " + average);

        // Control Structures
        if (age > 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are not an adult.");
        }

        // Switch statement example
        switch (age)
        {
            case 18:
                Console.WriteLine("You just became an adult!");
                break;
            case 25:
                Console.WriteLine("You are in your mid-twenties.");
                break;
            default:
                Console.WriteLine("Age is just a number.");
                break;
        }

        // For Loops
        Console.WriteLine("For Loops - Counting from 1 to 5:");
        for (int y = 1; y <= 5; y++)
        {
            Console.WriteLine(y);
        }

        // While Loop
        Console.WriteLine("While Loops");
        int i = 6;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }

        // Do-While Loop
        Console.WriteLine("Do-While Loops");
        int x = 6;
        do
        {
            Console.WriteLine(i);
            x++;
        }
        while (x <= 5);

        // Methods and Functions
        int number1 = 5;
        int number2 = 3;
        int result = AddNumbers(number1, number2); // Call the method
        Console.WriteLine("Sum of " + number1 + " and " + number2 + " is: " + result);

        // Calling a function with a return value
        double area = CalculateCircleArea(5.0); // Call the method
        Console.WriteLine("Area of a circle with radius 5: " + area);
    }

    // Method to add two numbers
    static int AddNumbers(int x, int y)
    {
        return x + y; // Return the sum of x and y
    }

    // Method to calculate the area of a circle
    static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area; // Return the calculated area
    }
}
