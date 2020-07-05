using ClockLibrary;
using System;

namespace ClockConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int choiceNumber;
            ClockWithArrows clockWithArrows = new ClockWithArrows();
            IClockAdapter clockAdapter = new ClockAdapter(clockWithArrows);
            bool isExit = false;
            while (!isExit)
            {
                Console.Clear();
                Console.WriteLine("1 - Set hour hand angle");
                Console.WriteLine("2 - Set minute hand angle");
                Console.WriteLine("3 - Set second hand angle");
                Console.WriteLine("4 - Show digital time");
                Console.WriteLine("5 - Exit");
                Console.Write("Your choice: ");
                try
                {
                    choiceNumber = int.Parse(Console.ReadLine());
                    switch (choiceNumber)
                    {
                        case 1:
                            Console.Write("Set angle between 0 and 720: ");
                            clockAdapter.SetHourAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.Write("Set angle between 0 and 360: ");
                            clockAdapter.SetMinuteAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            Console.Write("Set angle between 0 and 360: ");
                            clockAdapter.SetSecondAngle(double.Parse(Console.ReadLine()));
                            break;
                        case 4:
                            Console.WriteLine($"Digital time: {clockAdapter.ShowDigitalTime()}");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("Goodbye!");
                            isExit = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect menu select");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
