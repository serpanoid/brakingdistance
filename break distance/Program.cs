using System;
namespace CalculatingBrakingDistance
{
    class Program
    {
        public static double Dist(double v, double mu)
        {
            double vconv;
            vconv = v / 3.6;
            return (vconv * 1) + vconv * vconv / (2 * mu * 9.81);
        }
        public static double Speed(double d, double mu)
        {
            double v;
            v = (-2 * mu * 9.81 + Math.Sqrt(Math.Pow(2 * mu * 9.81, 2) + 4 * d * 2 * mu * 9.81)) / 2;
            return v * 3.6;
        }
        static void Main(string[] args)
        {
            double dist_calc = 0;
            double speed_calc = 0;
            double coefficient_of_friction = 0;
            try
            {
                Console.WriteLine("Введите тормозной путь (метры) для расчета скорости");
                dist_calc = Convert.ToDouble(Console.ReadLine());
                if (dist_calc <= 0)
                {
                    Console.WriteLine("Ошибка");
                    Environment.Exit(0);
                }
                Console.WriteLine("Введите скорость (км/ч) для расчета тормозного пути");
               
                speed_calc = Convert.ToDouble(Console.ReadLine());
                if (speed_calc <= 0)
                {
                    Console.WriteLine("Ошибка");
                    Environment.Exit(0);
                }
                Console.WriteLine("Введите коэффициент трения для расчета тормозного пути и скорости\n" +
                    " 0.1 -> гололед\n" +
                    " 0.2 -> снежный накат\n" +
                    " 0.3 - 0.4 -> мокрый асфальт\n" +
                    " 0.5 - 0.7 -> сухой асфальт");
               
                coefficient_of_friction = Convert.ToDouble(Console.ReadLine());
                if (coefficient_of_friction <= 0 || coefficient_of_friction > 0.7)
                {
                    Console.WriteLine("Ошибка");
                    Environment.Exit(0);
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OverflowException");
            }
            Console.WriteLine("Дистанция: " + Dist(speed_calc, coefficient_of_friction));
            Console.WriteLine("Скорсть: " + Speed(dist_calc, coefficient_of_friction));
            Console.ReadKey();
        }
    }
}