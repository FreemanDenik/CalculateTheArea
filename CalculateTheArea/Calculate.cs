using System;
using System.Collections.Generic;

namespace CalculateTheArea
{
   /* public enum Figure
    {
        Сircle,
        Triangle
    }*/
    public  class Calculate
    {
        private const float PI = 3.14F;
        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public double Сircle(double _radius)
        {
            return Math.Round( PI * Math.Pow(_radius, 2), 2);
        }
         /// <summary>
         /// Вычислить площадь треугольника
         /// </summary>
        public double Triangle(double _side1, double _side2, double _side3)
        {
            double[] arr = new double[] { _side1, _side2, _side3 };

            double polup = (_side1 + _side2 + _side3) / 2;

            return Math.Round( Math.Sqrt( polup * (polup - _side1) * (polup - _side2) * (polup - _side3)), 2);
        }

       /* public double DefineFigure(Figure figure, params double[] args)
        {
            switch (figure)
            {
                case Figure.Сircle:
                    return Сircle(args[0]);
                case Figure.Triangle:
                    return Triangle(args[0], args[1], args[2]);
                default:
                    return 0;
            }
        }*/
    }
}
