namespace P05_DrumSet
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            var drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var drumsQuality = drums.ConvertAll(x => x.ToString());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", drums));
                    Console.WriteLine($"Gabsy has {savings:F2}lv.");
                    break;
                }

                int hitPower = int.Parse(command);

                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hitPower;

                    if (drums[i] <= 0)
                    {
                        decimal drumPrice = int.Parse(drumsQuality[i]) * 3;

                        if (savings >= drumPrice)
                        {
                            drums[i] = int.Parse(drumsQuality[i]);
                            savings -= drumPrice;
                        }

                        else
                        {
                            drums.RemoveAt(i);
                            drumsQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
    }
}
