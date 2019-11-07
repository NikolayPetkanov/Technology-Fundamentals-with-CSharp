namespace P07_OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var currentPerson = Console.ReadLine().Split();

                if (currentPerson[0] == "End")
                {
                    people = people.OrderBy(x => x.Age).ToList();
                    Console.WriteLine(string.Join(Environment.NewLine, people));
                    break;
                }

                string name = currentPerson[0];
                string iD = currentPerson[1];
                int age = int.Parse(currentPerson[2]);

                var person = new Person
                {
                    Name = name,
                    ID = iD,
                    Age = age
                };

                people.Add(person);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
