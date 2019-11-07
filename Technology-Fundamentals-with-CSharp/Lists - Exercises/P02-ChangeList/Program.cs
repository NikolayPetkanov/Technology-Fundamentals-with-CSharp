namespace P02_ChangeList
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                else if (command[0] == "Delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(command[1]));
                }

                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
