namespace P04_PasswordValidator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine();
            bool checkLength = CheckLength(password);

            if (!checkLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool checkLettersAndDigits = CheckLettersAndDigits(password);

            if (!checkLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool consistTwoDigits = ConsistTwoDigits(password);

            if (!consistTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (checkLength && checkLettersAndDigits && consistTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10 ? true : false;
        }

        private static bool CheckLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                bool letterOrDigit = char.IsLetterOrDigit(password[i]);

                if (!letterOrDigit)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ConsistTwoDigits(string password)
        {
            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digits++;
                }
            }

            return digits >= 2 ? true : false;
        }
    }
}
