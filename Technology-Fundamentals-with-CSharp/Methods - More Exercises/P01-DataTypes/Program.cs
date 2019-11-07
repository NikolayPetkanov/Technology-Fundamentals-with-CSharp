namespace P01_DataTypes
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    Console.WriteLine(PrintInt(int.Parse(Console.ReadLine())));
                    break;

                case "real":
                    Console.WriteLine($"{PrintDouble(double.Parse(Console.ReadLine())):F2}"); 
                    break;

                case "string":
                    Console.WriteLine(PrintString(Console.ReadLine())); 
                    break;
            }
        }

        public static int PrintInt(int input)
        {
            return input * 2;
        }

        public static double PrintDouble(double input)
        {
            return input * 1.5;
        }

        public static string PrintString(string input)
        {
            return $"${input}$";
        }
    }
}
