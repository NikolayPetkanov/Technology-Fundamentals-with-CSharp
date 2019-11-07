namespace P08_AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "3:1")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }

                else if (command[0] == "merge")
                {
                    int startIndex = Math.Max(int.Parse(command[1]), 0);
                    int endIndex = Math.Min(int.Parse(command[2]), list.Count - 1);

                    if (startIndex > list.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }

                    list = MergeIndexes(list, startIndex, endIndex);
                }

                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    string element = list[index];
                    int parts = int.Parse(command[2]);
                    list = DivideIndex(list, index, element, parts);
                }
            }
        }

        public static List<string> MergeIndexes(List<string> list, int startIndex, int endIndex)
        {
            StringBuilder word = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                word.Append(list[i]);
            }

            list.RemoveRange(startIndex, endIndex - startIndex + 1);
            list.Insert(startIndex, word.ToString());
            return list;
        }

        public static List<string> DivideIndex(List<string> list, int index, string element, int parts)
        {
            int delimiter = element.Length / parts;
            int remainder = delimiter % 2;
            list.RemoveAt(index);
            var newElements = new List<string>();

            for (int i = 0; i < parts; i++)
            {
                if (i == parts - 1)
                {
                    newElements.Add(element.Substring(i * delimiter));
                }

                else
                {
                    newElements.Add(element.Substring(i * delimiter, delimiter));
                }
            }

            list.InsertRange(index, newElements);
            return list;
        }
    }
}
