using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
        }

        private Point FirstPoint { get; set; } = null!;
        private Point SecondPoint { get; set; } = null!;
        private Point ThirdPoint { get; set; } = null!;

        public override double CalculateArea()
        {
            Point length1 = SecondPoint - FirstPoint;
            Point length2 = ThirdPoint - FirstPoint;

            return (0.5) * Math.Abs(length1.X * length2.Y - length2.X * length1.Y);
        }

        public bool IsRectangular()
        {
            Point firstSide = SecondPoint - FirstPoint;
            Point secondSide = ThirdPoint - SecondPoint;
            Point thirdSide = ThirdPoint - FirstPoint;

            var getSquareSide = (Point side) =>
            {
                return Math.Pow(side.X, 2) + Math.Pow(side.Y, 2);
            };

            bool isFirstSide = getSquareSide(firstSide) == getSquareSide(secondSide) + getSquareSide(thirdSide);
            bool isSecondSide = getSquareSide(secondSide) == getSquareSide(firstSide) + getSquareSide(thirdSide);
            bool isThirdSide = getSquareSide(thirdSide) == getSquareSide(secondSide) + getSquareSide(firstSide);

            if (isFirstSide || isSecondSide || isThirdSide)
                return true;
            else
                return false;
        }
    }
}
