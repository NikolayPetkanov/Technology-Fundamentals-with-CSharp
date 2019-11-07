namespace P02_SongEncryption
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"^(?<artist>[A-Z][a-z'\s]+):(?<song>[A-Z\s]+)$";
            StringBuilder encryption = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    int key = match.Groups["artist"].Length;

                    char[] symbols = input.ToCharArray();

                    for (int i = 0; i < symbols.Length; i++)
                    {
                        if (symbols[i] == ':')
                        {
                            symbols[i] = '@';
                        }

                        if (symbols[i] != '\'' && symbols[i] != ' ')
                        {
                            if (char.IsLower(symbols[i]))
                            {
                                if (symbols[i] + key > 122)
                                {
                                    symbols[i] = (char)(96 + (key - (122 - symbols[i])));
                                }

                                else
                                {
                                    symbols[i] += (char)key;
                                }
                            }

                            else if (char.IsUpper(symbols[i]))
                            {
                                if (symbols[i] + key > 90)
                                {
                                    symbols[i] = (char)(64 + (key - (90 - symbols[i])));
                                }

                                else
                                {
                                    symbols[i] += (char)key;
                                }
                            }
                        }
                    }
                    input = new string(symbols);

                    Console.WriteLine($"Successful encryption: {input}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
