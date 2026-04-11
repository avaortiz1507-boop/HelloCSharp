using System;
using StudentRecords;


namespace HelloCSharp;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            RunDemo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static void RunDemo()
    {
        Console.WriteLine("=== Valid data working correctly ===");

        Order order = new Order(1, "Alice", 100.00);
        order.ApplyDiscount(10);
        order.PrintSummary();

        Student student = new Student(1, "Jonathan Joestar");
        Course course = new Course("CS101", "Introduction to Computer Science");
        student.EnrollInCourse(course);

        Console.WriteLine();
        foreach (var enrollment in student.Enrollments)
        {
            Console.WriteLine(enrollment);
        }

        Console.WriteLine();
        Console.WriteLine("=== Invalid data triggering exceptions ===");

        TryCreateStudent(0, "Invalid ID student");
        TryCreateStudent(2, string.Empty);
        TryCreateCourse(string.Empty, "Empty code course");
        TryCreateCourse("CS102", null);
        TryEnrollNullCourse(student);
    }

    static void TryCreateStudent(int id, string name)
    {
        try
        {
            var student = new Student(id, name);
            Console.WriteLine($"Created student: {student.Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Student creation failed: {ex.Message}");
        }
    }

    static void TryCreateCourse(string code, string name)
    {
        try
        {
            var course = new Course(code, name);
            Console.WriteLine($"Created course: {course.Code} - {course.Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Course creation failed: {ex.Message}");
        }
    }

    static void TryEnrollNullCourse(Student student)
    {
        try
        {
            student.EnrollInCourse(null!);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Enrollment failed: {ex.Message}");
        }
    }
}
