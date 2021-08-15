using CalculateTheArea;
using System;
using Xunit;
using MyProgram.Infrasrtructure;
namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void Test—ircle()
        {
            Calculate calc = new Calculate();
            var result = calc.—ircle(23);
            var format = Math.Round(result, 2);
            Assert.Equal(1661.06, format);
        }
        [Fact]
        public void TestTriangle()
        {
            Calculate calc = new Calculate();
            var result = calc.Triangle(20, 20, 20);
            var format = Math.Round(result, 3);
            Assert.Equal(173.205, format);
        }
        [Fact]
        public void TestRectangle()
        {
            Calculate calc = new Calculate();
            var result = calc.Rectangle(20, 20);
            var format = Math.Round(result, 3);
            Assert.Equal(400, format);
        }
    }
}
