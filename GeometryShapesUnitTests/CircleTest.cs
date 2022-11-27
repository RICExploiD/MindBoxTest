using GeometricShapes;

namespace GeometryShapesUnitTests
{
    public class CircleTest
    {
        [Fact]
        public void CorrectCalculationCircleSquare()
        {
            var raduis = new Random().NextDouble();
            var circle = new Circle(raduis);

            var obtainedResult = circle.Square;
            var properResult = Math.PI * Math.Pow(raduis, 2);

            Assert.Equal(obtainedResult, properResult);
        }

        [Fact]
        public void CorrectCalculationCirclePerimeter()
        {
            var raduis = new Random().NextDouble();
            var circle = new Circle(raduis);

            var properResult = 2 * Math.PI * raduis;
            
            var obtainedResult = circle.Perimeter;

            Assert.Equal(obtainedResult, properResult);
        }
    }
}