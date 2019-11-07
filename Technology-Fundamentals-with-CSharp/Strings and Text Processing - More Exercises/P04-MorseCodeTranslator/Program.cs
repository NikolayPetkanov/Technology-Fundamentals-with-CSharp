namespace P04_MorseCodeTranslator
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case ".-":
                        message.Append('A');
                        break;

                    case "-...":
                        message.Append('B');
                        break;

                    case "-.-.":
                        message.Append('C');
                        break;

                    case "-..":
                        message.Append('D');
                        break;

                    case ".":
                        message.Append('E');
                        break;

                    case "..-.":
                        message.Append('F');
                        break;

                    case "--.":
                        message.Append('G');
                        break;

                    case "....":
                        message.Append('H');
                        break;

                    case "..":
                        message.Append('I');
                        break;

                    case ".---":
                        message.Append('J');
                        break;

                    case "-.-":
                        message.Append('K');
                        break;

                    case ".-..":
                        message.Append('L');
                        break;

                    case "--":
                        message.Append('M');
                        break;

                    case "-.":
                        message.Append('N');
                        break;

                    case "---":
                        message.Append('O');
                        break;

                    case ".--.":
                        message.Append('P');
                        break;

                    case "--.-":
                        message.Append('Q');
                        break;

                    case ".-.":
                        message.Append('R');
                        break;

                    case "...":
                        message.Append('S');
                        break;

                    case "-":
                        message.Append('T');
                        break;

                    case "..-":
                        message.Append('U');
                        break;

                    case "...-":
                        message.Append('V');
                        break;

                    case ".--":
                        message.Append('W');
                        break;

                    case "-..-":
                        message.Append('X');
                        break;

                    case "-.--":
                        message.Append('Y');
                        break;

                    case "--..":
                        message.Append('Z');
                        break;

                    case "|":
                        message.Append(' ');
                        break;
                }
            }

            Console.WriteLine(message);
        }
    }
}
