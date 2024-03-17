namespace Lab7
{
    internal class Pilot : Human
    {
        public string AircraftType { get; set; }

        public Pilot(string name, int age, string aircraftType) : base(name, age)
        {
            AircraftType = aircraftType;
        }
        public override void InfoHumans()
        {
            base.InfoHumans();
            Console.WriteLine($"AircraftType: {AircraftType}\n");
        }
    }
}
