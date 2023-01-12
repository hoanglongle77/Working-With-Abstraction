using System;
using System.Collections.Generic;
using System.Text;

namespace Working_With_Abstraction.Problem_3
{
    internal class Student
    {
        private string name;
        private int age;
        private float grade;

        public string Name { get => name; set => name=value; }
        public int Age { get => age; set => age=value; }
        public float Grade { get => grade; set => grade=value; }

        public void Input()
        {
            Console.Write("Enter student's name: ");
            Name = Console.ReadLine();  
            Console.Write("Enter student's age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter student's grade: ");
            Grade = float.Parse(Console.ReadLine());
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}
