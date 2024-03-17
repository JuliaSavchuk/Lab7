namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");
            Builder builder = new Builder("John", 35, "Carpentry");
            builder.InfoHumans();
            Sailor sailor = new Sailor("Jack", 28, "Fishing Boat");
            sailor.InfoHumans();
            Pilot pilot = new Pilot("Emily", 30, "Boeing 737");
            pilot.InfoHumans();

            Console.WriteLine("\n_____Task 2_____\n");
            ForeignPassport myPassport = new ForeignPassport("John Doe", "123456789", "USA Visa", "ABC123");
            myPassport.PassportInfo();

            Console.WriteLine("\n_____Task 3_____\n");
            Crocodile croco = new Crocodile("Lili", 5, "Meat");
            Tiger tiger = new Tiger("Alex", 49, 6000);
            Kangaroo kangaroo = new Kangaroo("Frederica", 20, 8);
            croco.AnimalInfo();
            tiger.AnimalInfo();
            kangaroo.AnimalInfo();

            Console.WriteLine("\n_____Task 4_____\n");
            Figure[] shapes = new Figure[4];

            shapes[0] = new Rectangle(5, 4);
            shapes[1] = new Circle(3);
            shapes[2] = new RightTriangle(6, 8);
            shapes[3] = new Trapezoid(4, 6, 8);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Area of shape {i + 1}: {shapes[i].Area()}");
            }
        }
    }
}