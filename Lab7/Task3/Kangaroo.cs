namespace Lab7
{
    internal class Kangaroo : Animal
    {
        public int jumpLength { get; set; }

        public Kangaroo(string name, int age, int Lengthjump) : base(name, age)
        {
            jumpLength = Lengthjump;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Jump Length: {jumpLength} m");
        }
    }
}
