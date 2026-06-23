using System;
using System.Collections.Generic;
using System.Text;
//create an application for a manager for three types of employees under him who can generate reports
//Inheritance and Method Overriding (polymorphism)
namespace JUNE_030626
{
    class Employee
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void GenerateReport()
        {
            Console.WriteLine("Employee report");
        }
    }

    class Developer : Employee
    {
        public Developer(string name) : base(name)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine(Name + "(Developer)");
            Console.WriteLine("Project Progress: 80%");
        }
    }

    class Tester : Employee
    {
        public Tester(string name) : base(name)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine(Name + "(Tester)");
            Console.WriteLine("Bugs found: 12");
        }
    }

    class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine(Name + "(Manager)");
            Console.WriteLine("Project status reviewed.");
            Console.WriteLine("Developer and Tester reports analyzed");
        }
    }
    internal class Q1_reportHierarchy
    {
        public static void Run()
        {
            Developer dev = new Developer("Rahul");
            Tester tester = new Tester("Ajay");
            Manager manager = new Manager("Priya");

            Console.WriteLine("Developer report");
            dev.GenerateReport();

            Console.WriteLine();

            Console.WriteLine("Tester report");
            tester.GenerateReport();

            Console.WriteLine();

            Console.WriteLine("Manager report");
            manager.GenerateReport();

            Console.WriteLine();
        }
    }
}