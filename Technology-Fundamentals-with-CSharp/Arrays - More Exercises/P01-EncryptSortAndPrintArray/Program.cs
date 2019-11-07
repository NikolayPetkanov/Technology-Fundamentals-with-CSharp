namespace P01_EncryptSortAndPrintArray
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int[] sums = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    switch (name[j])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            sums[i] += (name[j] * name.Length);
                            break;

                        default:
                            sums[i] += (name[j] / name.Length);
                            break;
                    }
                }
            }

            Array.Sort(sums);

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
