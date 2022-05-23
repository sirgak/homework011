using System;

namespace homework005
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int gems;
            int equal = 5;
            int goldLeft;
            Console.Write("Введите количество золото: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 золото равна 1 криссталу, сколько криссталов хотите купить?");
            gems = Convert.ToInt32 (Console.ReadLine());
            goldLeft = gold - gems * equal;
            Console.WriteLine("У вас  " + gems + " криссталов " + goldLeft + " золото");
        }
    }
}
