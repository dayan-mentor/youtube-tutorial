// Define a base class 'Person'
public class Person
{
    // Encapsulation: Private fields
    private string _name;
    private int _age;

    // Properties to access the private fields (with getters and setters)
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Constructor to initialize the fields
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Virtual method to demonstrate polymorphism
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}");
    }
}

// Define a derived class 'Employee' that inherits from 'Person'
public class Employee : Person
{
    // Additional property specific to Employee
    public double Salary { get; set; }

    // Constructor that uses the base class constructor
    public Employee(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
    }

    // Overriding the base class method to demonstrate polymorphism
    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
    }
}

// Interface definition for demonstrating abstraction
public interface IWorkable
{
    void Work();
}

// Another derived class 'Manager' that inherits from 'Employee' and implements the interface
public class Manager : Employee, IWorkable
{
    public Manager(string name, int age, double salary) : base(name, age, salary) { }

    // Implementing the Work method from the IWorkable interface
    public void Work()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }

    // Overriding the DisplayInfo method to show manager-specific information
    public override void DisplayInfo()
    {
        Console.WriteLine($"[Manager] Name: {Name}, Age: {Age}, Salary: {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects (instances) of the Person and Employee classes
        Person person = new Person("Alice", 30);
        Employee employee = new Employee("Bob", 25, 50000);
        Manager manager = new Manager("Charlie", 40, 80000);

        // Demonstrating Encapsulation and Polymorphism
        person.DisplayInfo();  // Output: Name: Alice, Age: 30
        employee.DisplayInfo(); // Output: Name: Bob, Age: 25, Salary: 50000
        manager.DisplayInfo();  // Output: [Manager] Name: Charlie, Age: 40, Salary: 80000

        // Demonstrating Abstraction through Interface
        IWorkable workableManager = manager;
        workableManager.Work(); // Output: Charlie is managing the team.

        // Demonstrating Inheritance and Method Overriding
        Console.WriteLine("\n--- Inheritance and Overriding ---");
        Employee emp = new Manager("David", 35, 90000);
        emp.DisplayInfo(); // Output: [Manager] Name: David, Age: 35, Salary: 90000
    }
}
