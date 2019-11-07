namespace P06_CardsGame
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int gameLength = firstPlayer.Count;
            
            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }

                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }

            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }

            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
