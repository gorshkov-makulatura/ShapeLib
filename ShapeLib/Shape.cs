namespace ShapeLib
{
    /// <summary>
    /// Defines basic shape with Area.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets area of the shape
        /// </summary>
        public abstract float Area { get; }
    }

    /// <summary>
    /// Defines circle shape.
    /// </summary>
    public class Circle : Shape
    {
        public override float Area => MathF.Pow(Radius, 2) * MathF.PI;

        /// <summary>
        /// Gets radius of the circle.
        /// </summary>
        public float Radius { get; }

        /// <summary>
        /// Creates new circle with given radius.
        /// </summary>
        /// <param name="radius">Radius of the circle.</param>
        public Circle(float radius)
        {
            Radius = radius;
        }
    }

    /// <summary>
    /// Defines triangle shape.
    /// </summary>
    public class Triangle : Shape
    {
        public override float Area { get; }

        /// <summary>
        /// Gets a value indicating whether this triangle has right angle.
        /// </summary>
        public bool IsRight { get; }

        /// <summary>
        /// Gets length of the longest triangle side.
        /// </summary>
        public float Hypotenuse { get; }

        /// <summary>
        /// Gets length of triangle catheus.
        /// </summary>
        public float CatheusL { get; }

        /// <summary>
        /// Gets length of triangle catheus.
        /// </summary>
        public float CatheusR { get; }

        /// <summary>
        /// Gets length of side A.
        /// </summary>
        public float A { get; }

        /// <summary>
        /// Gets length of side B.
        /// </summary>
        public float B { get; }

        /// <summary>
        /// Gets length of side C.
        /// </summary>
        public float C { get; }

        /// <summary>
        /// Creates a new triangle with specified sides.
        /// </summary>
        /// <param name="a">Length of side A.</param>
        /// <param name="b">Length of side B.</param>
        /// <param name="c">Length of side C.</param>
        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;

            if (A > B && A > C)
            {
                Hypotenuse = A;
                CatheusL = B;
                CatheusR = C;
            }

            if (B > A && B > C)
            {
                Hypotenuse = B;
                CatheusL = A;
                CatheusR = C;
            }

            if (C > A && C > B)
            {
                Hypotenuse = C;
                CatheusL = A;
                CatheusR = B;
            }

            // Heron's formula
            float p = (A + B + C) * 0.5f;
            Area = MathF.Sqrt(p * (p - A) * (p - B) * (p - C));

            IsRight = MathF.Pow(CatheusL, 2) + MathF.Pow(CatheusR, 2) == MathF.Pow(Hypotenuse, 2);
        }
    }
}
