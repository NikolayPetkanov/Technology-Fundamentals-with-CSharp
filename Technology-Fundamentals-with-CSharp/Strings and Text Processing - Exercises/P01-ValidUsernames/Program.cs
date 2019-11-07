namespace P01_ValidUsernames
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var passwords = Console.ReadLine().Split(", ");
            bool isValid = true;

            foreach (var password in passwords)
            {
                if (password.Length >= 3 && password.Length <= 16)
                {
                    foreach (var letter in password)
                    {
                        if (!char.IsLetterOrDigit(letter) && letter != '-' && letter != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(password);
                    }

                    isValid = true;
                }
            }
        }
    }
}
