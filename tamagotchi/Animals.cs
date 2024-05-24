namespace tamagotchi
{
    internal class Animals
    {
        public int hunger = 10;
        public int filth = 10;
        public int energy = 90;

        public string name;
        public string color;

        public Animals(string Name, string Color)
        {
            name = Name;
            color = Color;
        }

    }
}
