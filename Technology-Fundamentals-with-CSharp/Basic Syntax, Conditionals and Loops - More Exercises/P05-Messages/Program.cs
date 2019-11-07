namespace P05_Messages
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string message = string.Empty;
            int digitLength = 0;
            int mainDigit = 0;
            int offset = 0;
            int letterIndex = 0;
            char letter = ' ';

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input / 1000 > 0)
                {
                    digitLength = 4;
                    mainDigit = input / 1000;
                }

                else if (input / 100 > 0)
                {
                    digitLength = 3;
                    mainDigit = input / 100;
                }

                else if (input / 10 > 0)
                {
                    digitLength = 2;
                    mainDigit = input / 10;
                }

                else
                {
                    digitLength = 1;
                    mainDigit = input;
                }

                offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                letterIndex = offset + digitLength - 1;
                letter = (char)(letterIndex + 97);

                if (input == 0)
                {
                    letter = ' ';
                }

                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}
