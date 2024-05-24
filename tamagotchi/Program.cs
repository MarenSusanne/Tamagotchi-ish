namespace tamagotchi
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Pick your pet!");
            Console.WriteLine("1. Cat\n2. Dog");
            var response = Convert.ToInt32(Console.ReadLine());
            var pet = response == 1 ? "Cat" : "Dog";
            Console.WriteLine($"You have chosen a {pet}. What color is it?");
            var petColor = Console.ReadLine();
            Console.WriteLine("Cute! Now you must name them!");
            var petName = Console.ReadLine();
            Animals myPet = new($"{petName}", $"{petColor}");
            Console.WriteLine("That is perfect! " + myPet.Name + " the " + myPet.Color + " " + pet);
            while (true)
            {
                StartGame();
            }
            

            void StartGame()
            {
                Console.WriteLine("What would you like to do with " + myPet.Name + "?");
                Console.WriteLine("1. Feed\n2. Play\n3. Brush\n4. Pet");
                var activity = Convert.ToInt32(Console.ReadLine());
                switch (activity)
                {
                    case 1 when myPet.Hunger == 0:
                        Console.WriteLine(myPet.Name + " is not hungry");
                        myPet.Energy = myPet.Energy >= 80 ? myPet.Energy = 100 : myPet.Energy += 20;
                        myPet.Filth = myPet.Filth >= 90 ? myPet.Filth = 100 : myPet.Filth += 10;
                        break;
                    case 1 when myPet.Hunger > 0:
                        Console.WriteLine();
                        myPet.Hunger = myPet.Hunger <= 20 ? myPet.Hunger = 0 : myPet.Hunger -= 20;
                        myPet.Energy = myPet.Energy >= 80 ? myPet.Energy = 100 : myPet.Energy += 20;
                        myPet.Filth = myPet.Filth >= 90 ? myPet.Filth = 100 : myPet.Filth += 10;
                        break;
                    case 2 when myPet.Energy == 0:
                        Console.WriteLine(myPet.Name + " is too tired to play");
                        myPet.Hunger = myPet.Hunger >= 80 ? myPet.Hunger = 100 : myPet.Hunger += 20;
                        myPet.Filth = myPet.Filth >= 80 ? myPet.Filth = 100 : myPet.Filth += 20;
                        break;
                    case 2 when myPet.Energy > 0:
                        Console.WriteLine();
                        myPet.Hunger = myPet.Hunger >= 80 ? myPet.Hunger = 100 : myPet.Hunger += 20;
                        myPet.Energy = myPet.Energy <= 20 ? myPet.Energy = 0 : myPet.Energy -= 20;
                        myPet.Filth = myPet.Filth >= 80 ? myPet.Filth = 100 : myPet.Filth += 20;
                        break;
                    case 3 when myPet.Filth == 0:
                        Console.WriteLine(myPet.Name + " is already clean");
                        myPet.Hunger = myPet.Hunger >= 90 ? myPet.Hunger = 100 : myPet.Hunger += 10;
                        myPet.Energy = myPet.Energy >= 90 ? myPet.Energy = 100 : myPet.Energy += 10;
                        break;
                    case 3 when myPet.Filth > 0:
                        Console.WriteLine();
                        myPet.Hunger = myPet.Hunger >= 90 ? myPet.Hunger = 100 : myPet.Hunger += 10;
                        myPet.Energy = myPet.Energy >= 90 ? myPet.Energy = 100 : myPet.Energy += 10;
                        myPet.Filth = myPet.Filth <= 20 ? myPet.Filth = 0 : myPet.Filth -= 20;
                        break;
                    case 4:
                        Console.WriteLine();
                        myPet.Hunger = myPet.Hunger >= 90 ? myPet.Hunger = 100 : myPet.Hunger += 10;
                        myPet.Energy = myPet.Energy >= 90 ? myPet.Energy = 100 : myPet.Energy += 10;
                        myPet.Filth = myPet.Filth >= 90 ? myPet.Filth = 100 : myPet.Filth += 10;
                        break;

                }

            }
        }

    }
}
