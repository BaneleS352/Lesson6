using System;
using System.Collections.Generic;

// Student class
public class Student
{
    // Properties
    public string Name { get; }
    public int Age { get; }
    public double Mark { get; }

    // Constructor
    public Student(string name, int age, double mark)
    {
        Name = name;
        Age = age;
        Mark = mark;
    }

    // Method to print student summary
    public void PrintSummary()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nMark: {Mark}");
    }
}

// Program entry point
public class Program
{
    public static void Main()
    {
        string[] names = { "Ava", "Ben", "Chen" };
        int[] ages = { 19, 21, 20 };
        double[] marks = { 72.5, 88.0, 64.0 };

        List<Student> students = new();

        // Add students
        for (int i = 0; i < names.Length; i++)
        {
            students.Add(new Student(names[i], ages[i], marks[i]));
        }

        Console.WriteLine("All students:");
        foreach (var student in students)
        {
            student.PrintSummary();
        }

        // Remove student at index 1
        students.RemoveAt(1);

        Console.WriteLine();
        Console.WriteLine("After removing index 1:");

        foreach (var student in students)
        {
            student.PrintSummary();
        }
    }
}