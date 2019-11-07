namespace P03_Vacation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = numberPeople;

            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        totalPrice *= 8.45;
                    }

                    else if (day == "Saturday")
                    {
                        totalPrice *= 9.80;
                    }

                    else if (day == "Sunday")
                    {
                        totalPrice *= 10.46;
                    }

                    if (numberPeople >= 30)
                    {
                        totalPrice -= (totalPrice * 0.15);
                    }

                    break;

                case "Business":
                    if (day == "Friday")
                    {
                        totalPrice *= 10.90;
                    }

                    else if (day == "Saturday")
                    {
                        totalPrice *= 15.60;
                    }

                    else if (day == "Sunday")
                    {
                        totalPrice *= 16;
                    }

                    if (numberPeople >= 100)
                    {
                        totalPrice -= ((totalPrice / numberPeople) * 10);
                    }

                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice *= 15;
                    }

                    else if (day == "Saturday")
                    {
                        totalPrice *= 20;
                    }

                    else if (day == "Sunday")
                    {
                        totalPrice *= 22.50;
                    }

                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        totalPrice -= (totalPrice * 0.05);
                    }

                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
