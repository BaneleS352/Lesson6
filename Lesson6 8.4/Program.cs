using System;
using System.Collections.Generic;

public class Program
{
    public class Employee
    {
        public string Name { get; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    public class Developer : Employee
    {
        public Developer(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    // TODO: Create an Intern class that inherits from Employee
    // TODO: Override Work() to print:
    // "{Name} is learning and helping with small tasks."
    public class Intern : Employee
    {
        public Intern(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is learning and helping with small tasks.");
        }
    }

    public static void Main()
    {
        List<Employee> team = new()
        {
            new Developer("Ada"),
            new Manager("Grace"),
			// TODO: Add an Intern object here
            new Intern("Sam")
        };

        foreach (var employee in team)
        {
            employee.Work();
        }
    }
}