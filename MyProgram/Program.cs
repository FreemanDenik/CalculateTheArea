using System;
using MyProgram.Infrasrtructure;
using CalculateTheArea; // это и есть та самая библиотека
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculate calc = new Calculate();

            var areaСircle = calc.Сircle(23);
            var areaTriangle = calc.Triangle(20, 20, 20);
            var areaRectangle = calc.Rectangle(23, 23); //расширенная функция (добавленная)

            Console.WriteLine($"Прощадь круга при радиусе 23: {areaСircle}");
            Console.WriteLine($"Прощадь треугольника при сторонах 20, 20, 20: {areaTriangle}");
            Console.WriteLine($"Прощадь квадратах при сторонах 23, 23: {areaRectangle} (расширенная функция)");

        }
    }
}
