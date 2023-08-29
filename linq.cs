using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20, Major = "Computer Science" },
            new Student { Id = 2, Name = "Bob", Age = 22, Major = "Engineering" },
            new Student { Id = 3, Name = "Charlie", Age = 21, Major = "Mathematics" },
            new Student { Id = 4, Name = "David", Age = 23, Major = "Physics" },
            new Student { Id = 5, Name = "Eve", Age = 19, Major = "Biology" }
        };

        // Example 1: Filtering using LINQ
        var computerScienceStudents = from student in students
                                      where student.Major == "Computer Science"
                                      select student;

        Console.WriteLine("Computer Science Students:");
        foreach (var student in computerScienceStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // Example 2: Sorting using LINQ
        var sortedStudents = from student in students
                             orderby student.Age
                             select student;

        Console.WriteLine("\nStudents Sorted by Age:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // Example 3: Projection using LINQ
        var studentNames = from student in students
                           select student.Name;

        Console.WriteLine("\nStudent Names:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}
