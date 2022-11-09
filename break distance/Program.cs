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
             Console.WriteLine("Введите тормозной путь (метры) для расчета скорости");
                dist_calc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите скорость (км/ч) для расчета тормозного пути");
                speed_calc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите коэффициент трения для расчета тормозного пути и скорости");
                coefficient_of_friction = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Скорсть: " + Speed(dist_calc, coefficient_of_friction));
            Console.WriteLine("Дистанция: " + Dist(speed_calc, coefficient_of_friction));
            Console.ReadKey();
        }
    }
}