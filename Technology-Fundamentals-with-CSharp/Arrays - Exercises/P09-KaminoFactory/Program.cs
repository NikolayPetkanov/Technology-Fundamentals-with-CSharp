namespace P09_KaminoFactory
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int elements = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int length = 0;
            int sum = 0;
            int startIndex = int.MaxValue;
            int row = 0;
            int currentRow = 0;
            int[] DNA = new int[elements];

            while (true)
            {
                if (command == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = command.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                currentRow++;
                int currentSum = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    currentSum += currentDNA[i];
                }

                if (currentRow == 1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sum = currentSum;
                }

                int currentStartIndex = -1;
                int currentLength = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1 && currentLength == 0)
                    {
                        currentStartIndex = i;
                        currentLength++;
                    }

                    else if (currentDNA[i] == 0)
                    {
                        currentLength = 0;
                        continue;
                    }

                    else
                    {
                        currentLength++;
                    }

                    if (currentLength >= length)
                    {
                        if (currentLength > length)
                        {
                            startIndex = currentStartIndex;
                            row = currentRow;
                            sum = currentSum;
                            DNA = currentDNA;
                            length = currentLength;
                        }

                        else if (currentLength == length && currentStartIndex < startIndex)
                        {
                            startIndex = currentStartIndex;
                            row = currentRow;
                            sum = currentSum;
                            DNA = currentDNA;
                            length = currentLength;
                        }

                        else if (currentSum > sum)
                        {
                            startIndex = currentStartIndex;
                            row = currentRow;
                            sum = currentSum;
                            DNA = currentDNA;
                        }
                    }

                    else if (currentLength <= 1 && currentStartIndex < startIndex)
                    {
                        startIndex = currentStartIndex;
                        row = currentRow;
                        sum = currentSum;
                        DNA = currentDNA;
                    }

                    else if (currentSum > sum)
                    {
                        startIndex = currentStartIndex;
                        row = currentRow;
                        sum = currentSum;
                        DNA = currentDNA;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
