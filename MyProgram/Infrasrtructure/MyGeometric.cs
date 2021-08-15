using CalculateTheArea;
namespace MyProgram.Infrasrtructure
{
    public static class MyGeometric
    {
        /// <summary>
        /// на тему "легкость добавления других фигур", расширения выручает
        /// </summary>
        /// <param name="_width"> Ширина квадрата </param>
        /// <param name="_height"> Высота квадрата </param>

        public static double Rectangle(this Calculate _calcul, double _width, double _height)
        {
            return  _width * _height;
        }
    }
}
