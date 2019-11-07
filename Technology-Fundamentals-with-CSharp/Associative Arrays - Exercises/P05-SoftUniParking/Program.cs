namespace P05_SoftUniParking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();

            for (int i = 0; i < commandsNumber; i++)
            {
                var currentUser = Console.ReadLine().Split().ToArray();

                if (currentUser[0] == "register")
                {
                    RegisterUser(currentUser, users);
                }

                else if (currentUser[0] == "unregister")
                {
                    UnregisterUser(currentUser, users);
                    
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + " => " + user.Value);
            }
        }

        public static void RegisterUser(string[] currentUser, Dictionary<string, string> users)
        {
            string userPlate = currentUser[2];

            if (users.ContainsKey(currentUser[1]))
            {
                Console.WriteLine($"ERROR: already registered with plate number {userPlate}");
            }

            else
            {
                users[currentUser[1]] = userPlate;
                Console.WriteLine($"{currentUser[1]} registered {userPlate} successfully");
            }
        }

        public static void UnregisterUser(string[] currentUser, Dictionary<string, string> users)
        {
            if (!users.ContainsKey(currentUser[1]))
            {
                Console.WriteLine($"ERROR: user {currentUser[1]} not found");
            }

            else
            {
                users.Remove(currentUser[1]);
                Console.WriteLine($"{currentUser[1]} unregistered successfully");
            }
        }
    }
}
