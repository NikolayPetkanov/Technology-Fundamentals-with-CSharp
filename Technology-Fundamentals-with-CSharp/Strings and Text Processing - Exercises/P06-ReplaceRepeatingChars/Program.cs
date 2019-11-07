namespace P06_ReplaceRepeatingChars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int startIndex = -1;
            int counter = 0;
            string result = string.Empty;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    if (counter == 0)
                    {
                        startIndex = i;
                    }

                    counter++;

                    if (i == input.Length - 1)
                    {
                        input = input.Remove(startIndex, counter);
                    }
                }

                else if (counter >= 1)
                {
                    input = input.Remove(startIndex, counter);
                    counter = 0;
                    i = startIndex;
                }

                else
                {
                    startIndex = i;
                }
            }

            Console.WriteLine(input);
        }
    }
}
