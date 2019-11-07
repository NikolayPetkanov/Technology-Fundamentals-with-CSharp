namespace P06_Courses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var courses = new Dictionary<string, List<string>>();
            var students = new List<string>();

            while (true)
            {
                var currentCourse = Console.ReadLine().Split(" : ").ToArray();

                if (currentCourse[0] == "end")
                {
                    courses = courses
                        .OrderByDescending(x => x.Value.Count)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var course in courses)
                    {
                        Console.WriteLine(course.Key + ": " + course.Value.Count);
                        var list = course.Value.OrderBy(x => x).ToList();

                        for (int i = 0; i < course.Value.Count; i++)
                        {
                            Console.WriteLine($"-- " + list[i]);
                        }
                    }

                    break;
                }

                string lesson = currentCourse[0];
                string student = currentCourse[1];

                if (!courses.ContainsKey(lesson))
                {
                    students = new List<string>();
                    courses[lesson] = students;
                }

                courses[lesson].Add(student);
            }
        }
    }
}
