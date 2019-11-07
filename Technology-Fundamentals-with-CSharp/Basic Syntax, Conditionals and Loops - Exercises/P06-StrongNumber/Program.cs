namespace P06_StrongNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            char[] cArray = number.ToCharArray();
            char digit = ' ';
            int numDigit = 0;
            int counter = 0;
            int sum = 0;

            for (int i = 0; i <= cArray.Length - 1; i++)
            {
                digit = cArray[i];
                numDigit = (int)Char.GetNumericValue(digit);

                if (numDigit == 1)
                {
                    sum += 1;
                    continue;
                }

                else if (numDigit == 0)
                {
                    sum += 1;
                    continue;
                }

                counter = numDigit;

                for (int j = 1; j < counter; j++)
                {
                    numDigit = numDigit * j;
                }

                sum += numDigit;
            }

            int num = Convert.ToInt32(number);

            if (sum == num)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
