using System;
using MyProgram.Infrasrtructure;
using CalculateTheArea;
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculate calc = new Calculate();

            var areaСircle = calc.Сircle(23);
            var areaTriangle = calc.Triangle(23, 23, 23);
            var areaRectangle = calc.Rectangle(23, 23);

            Console.WriteLine($"Прощадь круга при радиусе 23: {areaСircle}");
            Console.WriteLine($"Прощадь треугольника при сторонах 23, 23, 23: {areaTriangle}");
            Console.WriteLine($"Прощадь квадратах при сторонах 23, 23: {areaRectangle} (расширенная функция)");

        }
    }
}
