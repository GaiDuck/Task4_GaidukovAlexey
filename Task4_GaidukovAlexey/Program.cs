using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_GaidukovAlexey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите часы:");
            bool hoursParsed = int.TryParse(Console.ReadLine(), out int hours);
            
            Console.WriteLine("Введите минуты:");
            bool minutesParsed = int.TryParse(Console.ReadLine(), out int minutes);

            Console.WriteLine($"\nВы ввели время: {hours}:{minutes}");

            ArrowsAngle(hours, minutes);
        }


        public static void ArrowsAngle(int hours, int minutes)
        {
            if (minutes > 59 || hours > 24 || minutes < 0 || hours < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены некорректные данные.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
            else
            {
                if (hours > 12)
                {
                    hours /= 12;
                }

                double minuteArrowAngle = minutes * 6;
                double hourArrowAngle = hours * 30 + minutes * 0.5;
                double ArrowsAngle = Math.Abs(hourArrowAngle - minuteArrowAngle);

                if (ArrowsAngle > 180)
                {
                    ArrowsAngle = 360 - ArrowsAngle;
                }

                Console.WriteLine($"Угол между часовой и минутной стрелкой: {ArrowsAngle} градусов.");

                Console.ReadKey();
            }
        }
    }
}
