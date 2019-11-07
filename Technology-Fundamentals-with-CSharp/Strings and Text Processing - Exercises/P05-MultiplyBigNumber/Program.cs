namespace P05_MultiplyBigNumber
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            string secondNumber = Console.ReadLine().TrimStart('0');

            if (secondNumber == string.Empty || bigNumber == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            int smallNumber = int.Parse(secondNumber);
            StringBuilder result = new StringBuilder();
            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                string symbol = bigNumber[i].ToString();
                int digit = int.Parse(symbol);
                int resultDigit = (digit * smallNumber) + remainder;
                remainder = resultDigit / 10;
                result.Append(resultDigit % 10);

                if (i == 0 && remainder != 0)
                {
                    result.Append(remainder);
                }
            }

            var finalResult = result.ToString().ToCharArray();
            Array.Reverse(finalResult);
            Console.WriteLine(string.Join("", finalResult));
        }
    }
}
