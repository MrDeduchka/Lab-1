using System;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите уравнение 1 ");
            Console.Write("Введите a: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите уравнение 2 ");
            Console.Write("Введите a: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            if ((a1 == a2) && (b1 == b2))
                    { Console.WriteLine("Прямые совпадают"); }
            else if (a1 == a2)
                    { Console.WriteLine("Прямые параллельны"); }
            else
                    { Console.WriteLine("Прямые пересекаются"); }
            Console.ReadKey();
        }
    }
}
