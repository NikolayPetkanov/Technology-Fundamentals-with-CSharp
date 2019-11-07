namespace P02_OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var members = new List<Member>();

            for (int i = 0; i < lines; i++)
            {
                var currentMember = Console.ReadLine().Split();

                var member = new Member(currentMember[0], int.Parse(currentMember[1]));
                members.Add(member);
            }

            var oldestMember = members.OrderByDescending(x => x.Age).First();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Member
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
