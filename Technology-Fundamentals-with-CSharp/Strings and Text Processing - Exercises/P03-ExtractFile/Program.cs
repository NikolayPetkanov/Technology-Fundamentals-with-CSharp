namespace P03_ExtractFile
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(@"\");

            var file = input[input.Length - 1].Split('.');
            Console.WriteLine("File name: " + file[0]);
            Console.WriteLine("File extension: " + file[1]);
        }
    }
}
