namespace P11_ArrayManipulator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine("[" + string.Join(", ", array) + "]");
                    break;
                }

                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    ExchangeIndex(array, Convert.ToInt32(command[1]));
                }

                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        PrintMax(array, 0);
                    }

                    else if (command[1] == "odd")
                    {
                        PrintMax(array, 1);
                    }
                }

                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        PrintMin(array, 0);
                    }

                    else if (command[1] == "odd")
                    {
                        PrintMin(array, 1);
                    }
                }

                else if (command[0] == "first")
                {
                    if (command[2] == "even")
                    {
                        PrintFirst(array, 0, Convert.ToInt32(command[1]));
                    }

                    else if (command[2] == "odd")
                    {
                        PrintFirst(array, 1, Convert.ToInt32(command[1]));
                    }
                }

                else if (command[0] == "last")
                {
                    if (command[2] == "even")
                    {
                        PrintLast(array, 0, Convert.ToInt32(command[1]));
                    }

                    else if (command[2] == "odd")
                    {
                        PrintLast(array, 1, Convert.ToInt32(command[1]));
                    }
                }
            }
        }

        public static void ExchangeIndex(int[] array, int index)
        {
            if (index < 0 || index > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int i = 0; i <= index; i++)
            {
                int firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstElement;
            }
        }

        public static void PrintMax(int[] array, int remainder)
        {
            int index = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= maxNumber && array[i] % 2 == remainder)
                {
                    index = i;
                    maxNumber = array[i];
                }
            }

            if (maxNumber == int.MinValue)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine(index);
            }
        }

        public static void PrintMin(int[] array, int remainder)
        {
            int index = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minNumber && array[i] % 2 == remainder)
                {
                    index = i;
                    minNumber = array[i];
                }
            }

            if (minNumber == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine(index);
            }
        }

        public static void PrintFirst(int[] array, int remainder, int count)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] tempArray = new int[count];
            int counter = 0;
            bool isZero = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == remainder)
                {
                    tempArray[counter] = array[i];
                    counter++;
                    isZero = false;
                }

                if (counter == tempArray.Length)
                {
                    break;
                }
            }

            if (isZero)
            {
                Console.WriteLine("[]");
                return;
            }

            int[] finalArray = new int[counter];
            int finalArrayCounter = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] != 0)
                {
                    finalArray[finalArrayCounter] = tempArray[i];
                    finalArrayCounter++;
                }
            }

            Console.WriteLine("[" + string.Join(", ", finalArray) + "]");
        }

        public static void PrintLast(int[] array, int remainder, int count)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] tempArray = new int[count];
            int counter = 0;
            bool isZero = true;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == remainder)
                {
                    tempArray[counter] = array[i];
                    counter++;
                    isZero = false;
                }

                if (counter == tempArray.Length)
                {
                    break;
                }
            }

            Array.Reverse(tempArray);

            if (isZero)
            {
                Console.WriteLine("[]");
                return;
            }

            int[] finalArray = new int[counter];
            int finalArrayCounter = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] != 0)
                {
                    finalArray[finalArrayCounter] = tempArray[i];
                    finalArrayCounter++;
                }
            }

            Console.WriteLine("[" + string.Join(", ", finalArray) + "]");
        }
    }
}
