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
            Point firstSide = SecondPoint - FirstPoint;
            Point secondSide = ThirdPoint - FirstPoint;

            return (0.5) * Math.Abs(firstSide.X * secondSide.Y - secondSide.X * firstSide.Y);
        }

        public bool IsRectangular()
        {
            Point firstSide = SecondPoint - FirstPoint;
            Point secondSide = ThirdPoint - SecondPoint;
            Point thirdSide = ThirdPoint - FirstPoint;

            var getSquareLength = (Point side) =>
            {
                return Math.Pow(side.X, 2) + Math.Pow(side.Y, 2);
            };

            bool isFirstSide = getSquareLength(firstSide) == getSquareLength(secondSide) + getSquareLength(thirdSide);
            bool isSecondSide = getSquareLength(secondSide) == getSquareLength(firstSide) + getSquareLength(thirdSide);
            bool isThirdSide = getSquareLength(thirdSide) == getSquareLength(secondSide) + getSquareLength(firstSide);

            if (isFirstSide || isSecondSide || isThirdSide)
                return true;
            else
                return false;
        }
    }
}
