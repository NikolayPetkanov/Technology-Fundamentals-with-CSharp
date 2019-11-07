namespace P05_Login
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string username = Console.ReadLine();
            char[] cArray = username.ToCharArray();
            string password = "";

            for (int i = cArray.Length - 1; i >= 0 ; i--)
            {
                password += cArray[i];
            }

            string login = "";
            int counter = 0;

            while (login != password)
            {
                login = Console.ReadLine();
                counter++; 
                
                if (login != password)
                {
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }

                else if (login == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
