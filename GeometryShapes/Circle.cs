namespace GeometricShapes
{
    public class Circle : IGeomatricShape
    {
        #region Properties

        public double Square { get { return GetSquare(); } }
        public double Perimeter { get { return GetPerimeter(); } }

        public double Radius { get; init; }
        #endregion

        #region  Constructors
        
        public Circle() { }

        public Circle(double radius) { Radius = radius; }
        #endregion

        private double GetPerimeter() =>  2 * Math.PI * Radius;

        private double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}