namespace P07_StringExplosion
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int power = 0;
            int remainingPower = 0;
            int startIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>' && i < input.Length - 1)
                {
                    string digit = input[i + 1].ToString();
                    startIndex = i + 1;
                    power = startIndex + int.Parse(digit) + remainingPower;
                    power = Math.Min(power, input.Length);

                    for (int j = startIndex; j < power; j++)
                    {
                        if (input[j] != '>')
                        {
                            input = input.Remove(j, 1);
                            power--;
                            j--;
                        }

                        else
                        {
                            remainingPower = power - startIndex;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
