using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Sample data
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20, Grade = 85 },
            new Student { Id = 2, Name = "Bob", Age = 22, Grade = 90 },
            new Student { Id = 3, Name = "Charlie", Age = 19, Grade = 75 },
            new Student { Id = 4, Name = "David", Age = 21, Grade = 88 },
            new Student { Id = 5, Name = "Eve", Age = 20, Grade = 92 }
        };

        // 1. Basic LINQ Query - Filtering
        var highScorers = from s in students
                          where s.Grade > 80
                          select s;

        Console.WriteLine("Students with Grade > 80:");
        foreach (var student in highScorers)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
        }

        // 2. LINQ Method Syntax - Sorting
        var sortedStudents = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nStudents sorted by Age:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // 3. LINQ Projection - Selecting specific properties
        var studentNames = students.Select(s => s.Name).ToList();
        Console.WriteLine("\nStudent Names:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }

        // 4. LINQ Grouping
        var studentsGroupedByAge = students.GroupBy(s => s.Age);
        Console.WriteLine("\nStudents grouped by Age:");
        foreach (var group in studentsGroupedByAge)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"  Name: {student.Name}, Grade: {student.Grade}");
            }
        }

        // 5. LINQ Joining Example
        List<Course> courses = new List<Course>
        {
            new Course { StudentId = 1, CourseName = "Math" },
            new Course { StudentId = 2, CourseName = "Science" },
            new Course { StudentId = 3, CourseName = "History" },
            new Course { StudentId = 4, CourseName = "Math" }
        };

        var studentCourses = from s in students
                             join c in courses on s.Id equals c.StudentId
                             select new { s.Name, c.CourseName };

        Console.WriteLine("\nStudent Course Enrollments:");
        foreach (var sc in studentCourses)
        {
            Console.WriteLine($"Name: {sc.Name}, Course: {sc.CourseName}");
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
}

public class Course
{
    public int StudentId { get; set; }
    public string CourseName { get; set; }
}