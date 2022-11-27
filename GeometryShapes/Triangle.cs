namespace GeometricShapes
{
    public class Triangle : IGeomatricShape
    {
        #region Properties

        public double Square { get => GetSquare(); }
        public double Perimeter { get => GetPerimeter(); } 

        public bool IsRightTriangle { get => GetIsRightTriangle(); }

        public double ALengthSide { get; init; }
        public double BLengthSide { get; init; }
        public double CLengthSide { get; init; }

        public double HeightBasedOnASide { get { return GetHeight(ALengthSide); } }
        public double HeightBasedOnBSide { get { return GetHeight(BLengthSide); } }
        public double HeightBasedOnCSide { get { return GetHeight(CLengthSide); } }
        #endregion

        #region  Constructors

        public Triangle() { }

        /// <param name="A">A side length of triangle</param>
        /// <param name="B">B side length of triangle</param>
        /// <param name="C">C side length of triangle</param>
        public Triangle(double A, double B, double C) 
        {
            ALengthSide = A;
            BLengthSide = B;
            CLengthSide = C;
        }
        #endregion

        private double GetPerimeter() => ALengthSide + BLengthSide + CLengthSide;

        private double GetSquare() => ALengthSide / 2 * HeightBasedOnASide;

        private double GetHeight(double Side)
        {
            var halfPerimeter = GetPerimeter() / 2;

            var height = Math.Sqrt(halfPerimeter * 
                (halfPerimeter - ALengthSide) * 
                (halfPerimeter - BLengthSide)  * 
                (halfPerimeter - CLengthSide)) * 2 / Side;

            return height;
        }

        /// <summary>
        /// Calcualtes whether a triangle is rectangular according to the Pythagorean theorem.
        /// </summary>
        private bool GetIsRightTriangle()
        {
            var isASideLongest = ALengthSide > BLengthSide && ALengthSide > CLengthSide;
            var isBSideLongest = BLengthSide > ALengthSide && BLengthSide > CLengthSide;

            // If a side is the longest then it is a hypotenuse
            // hypotenuse^2 = A^2 + B^2 - means this triangle a rectangular

            if (isASideLongest)
                return Math.Pow(ALengthSide, 2)
                    .Equals(Math.Pow(BLengthSide, 2) + Math.Pow(CLengthSide, 2));

            else if (isBSideLongest)
                return Math.Pow(BLengthSide, 2)
                    .Equals(Math.Pow(ALengthSide, 2) + Math.Pow(CLengthSide, 2));

            else
                return Math.Pow(CLengthSide, 2)
                    .Equals(Math.Pow(ALengthSide, 2) + Math.Pow(BLengthSide, 2));
        }
    }
}
