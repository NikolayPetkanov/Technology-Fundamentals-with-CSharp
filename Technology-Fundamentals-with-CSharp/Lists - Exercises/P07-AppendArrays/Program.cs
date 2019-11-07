namespace P07_AppendArrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split('|').ToList();
            var finalList = new List<string>();
            numbers.Reverse();

            foreach (var item in numbers)
            {
                string[] currentNumbers = item.Split(' ');

                foreach (var number in currentNumbers)
                {
                    if (number != "")
                    {
                        finalList.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
