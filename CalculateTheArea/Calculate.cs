using System;

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
        public double Сircle(double _radius)
        {
            return PI * Math.Pow(_radius, 2);
        }
        public double Triangle(double _side1, double _side2, double _side3)
        {
            double polup = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt( polup * (polup - _side1) * (polup - _side2) * (polup - _side3) );
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
