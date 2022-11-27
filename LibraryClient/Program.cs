namespace LibraryClient
{
    using GeometricShapes;

    internal class Program
    {
        static void Main()
        {
            IGeomatricShape circle = new Circle(15d);
            IGeomatricShape triangle = new Triangle(3d, 4d, 5d);

            var circleSquare = GeometricShapes.GetSquare(circle);
            var triangleSquare = GeometricShapes.GetSquare(triangle);

            var resultMessage =
                $"Circle square is: {circleSquare}\n\n" +
                $"Triangle square is: {triangleSquare}\n";

            Console.WriteLine(resultMessage);
        }
    }
}