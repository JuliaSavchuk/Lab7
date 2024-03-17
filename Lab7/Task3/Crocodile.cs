namespace Lab7
{
    internal class Crocodile : Animal
    {
        public string favoriteFood { get; set; }

        public Crocodile(string name, int age,string favorFood) : base(name, age)
        {
            favoriteFood = favorFood;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Favorite Food: {favoriteFood}");
        }
    }
}
