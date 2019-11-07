namespace P04_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var currentStudent = Console.ReadLine().Split();
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                double grade = double.Parse(currentStudent[2]);

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
