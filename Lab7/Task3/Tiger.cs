namespace Lab7
{
    internal class Tiger : Animal
    {
        public int Population { get; set; }

        public Tiger(string name, int age, int population) : base(name, age)
        {
            Population = population;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Population: {Population}");
        }
    }
}
