namespace Lab7
{
    internal class Sailor : Human
    {
        public string ShipType { get; set; }

        public Sailor(string name, int age, string shipType) : base(name, age)
        {
            ShipType = shipType;
        }

        public override void InfoHumans()
        {
            base.InfoHumans();
            Console.WriteLine($"ShipType: {ShipType}\n");
        }
    }
}
