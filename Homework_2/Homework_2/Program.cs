using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Введите радиус = ");
            double radius = double.Parse(Console.ReadLine());

            while (radius <= -6 || radius >=12)
            {
                Console.WriteLine("Введеное значение выходит за пределы определения функции");
                Console.Write("Введите новый радиус (R > 0) = ");
                radius = double.Parse(Console.ReadLine());
            }

            for (double x = -6; x <= 12; x = x + 0.2)
            {
                if (x < -4)
                {
                    Console.WriteLine($"y({Math.Round(x, 2)}) = {Math.Round(function_1(), 2)}");
                }
                else if (x >= -4 && x <= 0)
                {
                    Console.WriteLine($"y({Math.Round(x, 2)}) = {Math.Round(function_2(x), 2)}");
                }
                else if (x >= 0 && x <= 2)
                {
                    Console.WriteLine($"y({Math.Round(x, 2)}) = {Math.Round(function_3(x), 2)}");
                }
                else if (x >= 2 && x <= 12)
                {
                    Console.WriteLine($"y({Math.Round(x, 2)}) = {Math.Round(function_4(x), 2)}");
                }
            }

            Console.ReadKey();
        }

        //определяем функции фрагментов : 3 прямые и одна половина параболы

        static double function_1()
        {
            //прямая параллельна оси Ox => kx = 0
            double y = -2;
            return y;
        }
        static double function_2(double x)
        {
            double y = 0.25 * x;
            return y;
        }
        static double function_3(double x)
        {
            if (x >= 0)
            {
                double y = Math.Pow(x, 2);
                return y;
            }
            else { return 0; }   
        }
        static double function_4(double x)
        {
            double y = -0.5 * x + 5;
            return y;

        }
        
    }
}