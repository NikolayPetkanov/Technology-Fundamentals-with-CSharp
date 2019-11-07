namespace P03_QuestsJournal
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Retire!")
                {
                    Console.WriteLine(string.Join(", ", list));
                    break;
                }

                else if (command[0] == "Start")
                {
                    string quest = command[1];

                    if (!list.Contains(quest))
                    {
                        list.Add(quest);
                    }
                }

                else if (command[0] == "Complete")
                {
                    string quest = command[1];
                    list.Remove(quest);
                }

                else if (command[0] == "Side Quest")
                {
                    string quest = command[1];
                    string sideQuest = command[2];

                    if (!list.Contains(sideQuest) && list.Contains(quest))
                    {
                        int index = list.IndexOf(quest) + 1;
                        list.Insert(index, sideQuest);
                    }
                }

                else if (command[0] == "Renew")
                {
                    string quest = command[1];

                    if (list.Contains(quest))
                    {
                        list.Remove(quest);
                        list.Add(quest);
                    }
                }
            }
        }
    }
}
