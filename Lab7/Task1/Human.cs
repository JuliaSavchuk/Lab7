namespace Lab7
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void InfoHumans()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
    }
}
