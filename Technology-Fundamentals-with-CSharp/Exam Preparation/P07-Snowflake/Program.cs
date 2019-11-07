namespace P07_Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string surfacePattern = @"^(?<surface>[^A-Za-z0-9]+)$";
            string mantlePattern = @"^(?<mantle>[0-9_]+)$";
            string corePattern = @"^(?<surface>[^A-Za-z0-9]+)(?<mantle>[0-9_]+)(?<core>[A-Za-z]+)(?<mantle>[0-9_]+)(?<surface>[^A-Za-z0-9]+)$";

            Match firstLine = Regex.Match(Console.ReadLine(), surfacePattern);
            Match secondLine = Regex.Match(Console.ReadLine(), mantlePattern);
            Match thirdLine = Regex.Match(Console.ReadLine(), corePattern);
            Match fourthLine = Regex.Match(Console.ReadLine(), mantlePattern);
            Match fifthLine = Regex.Match(Console.ReadLine(), surfacePattern);

            if (fifthLine.Success && secondLine.Success && thirdLine.Success &&
                fourthLine.Success && fifthLine.Success)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(thirdLine.Groups["core"].Length);
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
