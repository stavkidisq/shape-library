using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestShapeLibrary
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateTriangleArea()
        {
            Shape triangle = new Triangle(new Point(0, 0), new Point(1, 0), new Point(0, 1));
            double triangleArea = triangle.CalculateArea();
            Assert.Equal(0.5, triangleArea);
        }

        [Fact]
        public void CheckRectangularTriangle()
        {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(1, 0), new Point(0, 1));
            Assert.True(triangle.IsRectangular());
        }
    }
}
