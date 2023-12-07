using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentW4
{
        public class Student
    {
        private string name;
        private int age;
        private string major;

        // Constructor to initialize name, age, and major
        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        // Method to introduce the student
        public void Introduce()
        {
            Console.WriteLine($"Hello, I'm {name}, my age is {age} and my major is {major}.");
        }
    }
}
