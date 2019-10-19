using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, unit, ten;
            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out year))
            {
                if ((year >= 20) && (year <= 69))
                {
                    unit = year % 10;
                    ten = year / 10;

                    switch (ten)
                    {
                        case 2:
                            Console.Write("Двадцать ");
                            break;
                        case 3:
                            Console.Write("Тридцать ");
                            break;
                        case 4:
                            Console.Write("Сорок ");
                            break;
                        case 5:
                            Console.Write("Пятьдесят ");
                            break;
                        case 6:
                            Console.Write("Шестьдесят ");
                            break;
                    }
                    switch (unit)
                    {
                        case 0:
                            Console.Write("");
                            break;
                        case 1:
                            Console.Write("один ");
                            break;
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                    }
                    switch (unit)
                    {
                        case 0:
                            Console.Write("лет");
                            break;
                        case 5:
                            Console.Write("лет");
                            break;
                        case 6:
                            Console.Write("лет");
                            break;
                        case 7:
                            Console.Write("лет");
                            break;
                        case 8:
                            Console.Write("лет");
                            break;
                        case 9:
                            Console.Write("лет");
                            break;
                        case 1:
                            Console.Write("год");
                            break;
                        case 2:
                            Console.Write("год");
                            break;
                        case 3:
                            Console.Write("год");
                            break;
                        case 4:
                            Console.Write("год");
                            break;
                    }
                }
                else { Console.Write("Число не пренадлежит от 20 до 69."); }
            }

            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey();
        }
    }
}
