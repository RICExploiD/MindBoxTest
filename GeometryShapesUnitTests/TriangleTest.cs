using GeometricShapes;

namespace GeometryShapesUnitTests
{
    public class TriangleTest
    {
        [Fact]
        public void CorrectCalculationTriangleSquare()
        {
            var ASide = new Random().NextDouble();
            var BSide = new Random().NextDouble();
            var CSide = new Random().NextDouble();

            var halfPerimeter = (ASide + BSide + CSide) / 2;

            var height = Math.Sqrt(halfPerimeter *
                (halfPerimeter - ASide) *
                (halfPerimeter - BSide) *
                (halfPerimeter - CSide)) * 2 / ASide;

            var triangle = new Triangle(ASide, BSide, CSide);

            var properResult = ASide / 2 * height;

            var obtainedResult = triangle.Square;

            Assert.Equal(obtainedResult, properResult);
        }

        [Fact]
        public void CorrectCalculationTrianglePerimeter()
        {
            var ASide = new Random().NextDouble();
            var BSide = new Random().NextDouble();
            var CSide = new Random().NextDouble();

            var triangle = new Triangle(ASide, BSide, CSide);

            var properResult = ASide + BSide + CSide;

            var obtainedResult = triangle.Perimeter;

            Assert.Equal(obtainedResult, properResult);
        }
    }
}