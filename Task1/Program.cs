using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double MyDelegat(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");
            bool number = double.TryParse(Console.ReadLine(), out double r);
            if (number)
            {
                Console.Write("Длина окружности: ");
                CalculationOut(5, Circumference);
                Console.Write("Площадь круга: ");
                CalculationOut(5, СircleArea);
                Console.Write("Объем шара: ");
                CalculationOut(5, BallVolume);
            }
            else
            {
                Console.WriteLine("Неверный формат данных");
            }
       
            Console.ReadKey();
        }
        static void CalculationOut(double r, MyDelegat myDelegat) => Console.WriteLine(Math.Round(myDelegat(r),2));
        static double Circumference(double r) => 2 * Math.PI * r;
        static double СircleArea(double r) => Math.PI * Math.Pow(r, 2);
        static double BallVolume(double r) => (double)4/3 * Math.PI * Math.Pow(r, 3);
    }
}
