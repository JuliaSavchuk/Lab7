namespace Lab7
{
    internal class Passport
    {
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public Passport(string name, string passnum)
        {
            FullName = name;
            PassportNumber = passnum;
        }

        public virtual void PassportInfo()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
        }
    }
}
