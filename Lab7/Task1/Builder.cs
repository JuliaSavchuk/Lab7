namespace Lab7
{
    internal class Builder : Human
    {
        public string Specialization { get; set; }

        public Builder(string name, int age, string specialization) : base(name, age)
        {
            Specialization = specialization;
            
        }

        public override void InfoHumans()
        {
            base.InfoHumans();
            Console.WriteLine($"Specialization: {Specialization}\n");
        }
    }
}
