namespace Lab7
{
    internal class Trapezoid : Figure
    {
        public double Height { get; set; }
        public double LongBase { get; set; }
        public double ShortBase { get; set; }

        public Trapezoid(double height, double longBase, double shortBase)
        {
            Height = height;
            LongBase = longBase;
            ShortBase = shortBase;
        }

        public override double Area()
        {
            return 0.5 * (LongBase + ShortBase) * Height;
        }
    }
}
