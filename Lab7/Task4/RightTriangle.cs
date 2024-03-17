namespace Lab7
{
    internal class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double bas, double height)
        {
            Base = bas;
            Height = height;
        }
        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
