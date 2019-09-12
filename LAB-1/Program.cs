using System;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string num1;
            string num2;
            if (num % 2 == 0)
            {
                num1 = "Четное";
             }
            else
            {
                num1 = "Нечетное";
            }
            if (num >= 100)
            {
                num2 = "трехзначное число";
            }
            else if (num >= 10)
            {
                num2 = "двухзначное число";
            }
            else
            {
                num2 = "однозначное число";
            }
            Console.WriteLine(num1, num2);
            Console.ReadKey();

        }
    }
}
