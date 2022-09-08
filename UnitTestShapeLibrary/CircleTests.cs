using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestShapeLibrary
{
    public class CircleTests
    {
        [Fact]
        public void CalculateCircleArea()
        {
            Shape circle = new Circle(10);
            double circleArea = circle.CalculateArea();
            Assert.Equal(Math.PI * 100, circleArea);
        }
    }
}
