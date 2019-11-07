namespace P03_TakeSkipRope
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var text = new List<string>(input.Select(c => c.ToString()));
            var digits = new List<int>();
            int textLength = text.Count;
            int number = 0;

            for (int i = 0; i < textLength; i++)
            {
                if (i == text.Count)
                {
                    break;
                }

                if (int.TryParse(text[i], out number))
                {
                    digits.Add(Convert.ToInt32(text[i]));
                    text.RemoveAt(i);
                    i--;
                }
            }

            var takeList = new List<int>();
            var skipList = new List<int>();
            string result = string.Empty;
            int currentIndex = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);

                    for (int j = currentIndex; j < currentIndex + 
                        Math.Min(digits[i], text.Count - currentIndex); j++)
                    {
                        result += text[j];
                    }

                    currentIndex += digits[i];
                }

                else
                {
                    skipList.Add(digits[i]);
                    currentIndex += digits[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
