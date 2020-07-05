using System;
using ClockLibrary;

namespace TaskEpam.Net2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int choiceNumber;
            ClockWithArrows clockWithArrows = new ClockWithArrows();
            IClockAdapter clockAdapter = new ClockAdapter(clockWithArrows);
            bool isExit = false;
            while(!isExit)
            {
                Console.Clear();
                Console.WriteLine("1 - Установить угол поворота часовой стрелки");
                Console.WriteLine("2 - Установить угол поворота минутной стрелки");
                Console.WriteLine("3 - Установить угол поворота секундной стрелки");
                Console.WriteLine("4 - Показать цифровое время");
                Console.WriteLine("5 - Выход");
                Console.Write("Ваш выбор: ");
                try
                {
                    choiceNumber = int.Parse(Console.ReadLine());
                    switch (choiceNumber)
                    {
                        case 1:
                            Console.Write("Введите угол от 0 до 720: ");
                            clockAdapter.SetHourAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.Write("Введите угол от 0 до 360: ");
                            clockAdapter.SetMinuteAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            Console.Write("Введите угол от 0 до 360: ");
                            clockAdapter.SetSecondAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 4:
                            Console.WriteLine($"Время в цифровом виде: {clockAdapter.ShowDigitalTime()}");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("До свидания!");
                            isExit = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор меню");
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
