namespace P03_TreasureFinder
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string firstRegex = @"&(\w+)&";
            string secondRegex = @"<(\w+)>";
            Match types;
            Match coordinates;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "find")
                {
                    break;
                }

                var message = input.ToCharArray();
                int keyIndex = 0;

                for (int i = 0; i < message.Length; i++)
                {
                    message[i] -= (char)key[keyIndex];
                    keyIndex++;

                    if (keyIndex == key.Length)
                    {
                        keyIndex = 0;
                    }
                }

                input = new string(message);

                types = Regex.Match(input, firstRegex);
                coordinates = Regex.Match(input, secondRegex);

                string type = types.Groups[1].Value;
                string coordinate = coordinates.Groups[1].Value;

                Console.WriteLine($"Found {type} at {coordinate}");
            }
        }
    }
}
