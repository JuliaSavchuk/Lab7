namespace Lab7
{
    class Vehicle
    {
        public string Brand { get; set; }

        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;

            Console.WriteLine("\tVehicle");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nSpeed: {Speed}");
        }
    }
}
