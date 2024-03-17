namespace Lab7
{
    internal class ForeignPassport : Passport
    {
        public string Visas { get; set; }
        public string ForeignNumber { get; set; }

        public ForeignPassport(string name, string passnum, string visas, string foreigntNumber) : base(name,passnum)
        {
            Visas = visas;
            ForeignNumber = foreigntNumber;
        }

        public override void PassportInfo()
        {
            base.PassportInfo();
            Console.WriteLine($"Foreign Passport Number: {ForeignNumber}\nVisas: {Visas}");

        }
    }
}
