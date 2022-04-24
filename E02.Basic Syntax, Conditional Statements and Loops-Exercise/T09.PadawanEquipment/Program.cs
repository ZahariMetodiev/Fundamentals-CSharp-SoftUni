using System;

namespace T09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amoundOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int lightsabersCount = (int)Math.Ceiling(studentsCount * 1.10);
            int beltsCount = studentsCount - studentsCount / 6;

            double totalPrice = lightsabersPrice * lightsabersCount +
                                robePrice * studentsCount +
                                beltsPrice * beltsCount;

            if (amoundOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalPrice - amoundOfMoney:f2}lv more.");
            }
        }
    }
}
