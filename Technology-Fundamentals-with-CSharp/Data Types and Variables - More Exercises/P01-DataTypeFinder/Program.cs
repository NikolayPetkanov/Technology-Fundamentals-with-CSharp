namespace P01_DataTypeFinder
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();;
            string dataType = string.Empty;

            while (input != "END")
            {
                if (input == "END")
                {
                    break;
                }

                else if (int.TryParse(input, out int result))
                {
                    dataType = "integer";
                }

                else if (double.TryParse(input, out double result1))
                {
                    dataType = "floating point";
                }

                else if (bool.TryParse(input, out bool result2))
                {
                    dataType = "boolean";
                }

                else if (char.TryParse(input, out char result3))
                {
                    dataType = "character";
                }

                else 
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}
