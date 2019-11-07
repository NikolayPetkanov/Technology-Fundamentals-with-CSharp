namespace P07_StudentAcademy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                string currentStudent = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(currentStudent))
                {
                    students[currentStudent] = new List<double>();
                }

                students[currentStudent].Add(currentGrade);
            }

            students = students.
                Where(x => x.Value.Average() >= 4.50).
                OrderByDescending(x => x.Value.Average()).
                ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in students)
            {
                double averageGrade = student.Value.Average();
                Console.WriteLine(student.Key + $" -> {averageGrade:F2}");
            }
        }
    }
}
