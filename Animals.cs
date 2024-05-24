namespace tamagotchi
{
    internal class Animals(string name, string color)
    {
        public int Hunger = 10;
        public int Filth = 10;
        public int Energy = 90;

        public string Name = name;
        public string Color = color;
    }
}
