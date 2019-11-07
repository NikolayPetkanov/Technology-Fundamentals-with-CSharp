namespace P09_PadawanEquipment
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal lightsaberSum = (students + (Math.Ceiling(students * 0.1m))) * lightsaberPrice;
            decimal robeSum = students * robePrice;
            decimal beltSum = (students - (students / 6)) * beltPrice;
            decimal totalSum = lightsaberSum + robeSum + beltSum;

            if (totalSum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalSum - money):F2}lv more.");
            }
        }
    }
}
