namespace P04_MixedUpLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            secondList.Reverse();

            int smallerCount = Math.Min(firstList.Count, secondList.Count);
            var mixedList = new List<int>();

            for (int i = 0; i < smallerCount; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }

            int firstNumber;
            int secondNumber;

            if (firstList.Count > secondList.Count)
            {
                firstNumber = Math.Min(firstList[firstList.Count - 2],
                    firstList[firstList.Count - 1]);

                secondNumber = Math.Max(firstList[firstList.Count - 2],
                    firstList[firstList.Count - 1]);
            }

            else
            {
                firstNumber = Math.Min(secondList[secondList.Count - 2],
                    secondList[secondList.Count - 1]);

                secondNumber = Math.Max(secondList[secondList.Count - 2],
                    secondList[secondList.Count - 1]);
            }

            var finalList = new List<int>();

            foreach (var number in mixedList)
            {
                if (number > firstNumber && number < secondNumber)
                {
                    finalList.Add(number);
                }
            }

            finalList.Sort();
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
