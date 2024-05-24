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
            Console.WriteLine("That is perfect! " + myPet.name + " the " + myPet.color + " " + pet);
            while (true)
            {
                StartGame();
            }
            
            return;

            void StartGame()
            {
                Console.WriteLine("What would you like to do with " + myPet.name + "?");
                Console.WriteLine("1. Feed\n2. Play\n3. Brush\n4. Pet");
                var activity = Convert.ToInt32(Console.ReadLine());
                switch (activity)
                {
                    case 1 when myPet.hunger == 0:
                        Console.WriteLine(myPet.name + " is not hungry");
                        myPet.energy = myPet.energy >= 80 ? myPet.energy = 100 : myPet.energy += 20;
                        myPet.filth = myPet.filth >= 90 ? myPet.filth = 100 : myPet.filth += 10;
                        break;
                    case 1 when myPet.hunger > 0:
                        Console.WriteLine();
                        myPet.hunger = myPet.hunger <= 20 ? myPet.hunger = 0 : myPet.hunger -= 20;
                        myPet.energy = myPet.energy >= 80 ? myPet.energy = 100 : myPet.energy += 20;
                        myPet.filth = myPet.filth >= 90 ? myPet.filth = 100 : myPet.filth += 10;
                        break;
                    case 2 when myPet.energy == 0:
                        Console.WriteLine(myPet.name + " is too tired to play");
                        myPet.hunger = myPet.hunger >= 80 ? myPet.hunger = 100 : myPet.hunger += 20;
                        myPet.filth = myPet.filth >= 80 ? myPet.filth = 100 : myPet.filth += 20;
                        break;
                    case 2 when myPet.energy > 0:
                        Console.WriteLine();
                        myPet.hunger = myPet.hunger >= 80 ? myPet.hunger = 100 : myPet.hunger += 20;
                        myPet.energy = myPet.energy <= 20 ? myPet.energy = 0 : myPet.energy -= 20;
                        myPet.filth = myPet.filth >= 80 ? myPet.filth = 100 : myPet.filth += 20;
                        break;
                    case 3 when myPet.filth == 0:
                        Console.WriteLine(myPet.name + " is already clean");
                        myPet.hunger = myPet.hunger >= 90 ? myPet.hunger = 100 : myPet.hunger += 10;
                        myPet.energy = myPet.energy >= 90 ? myPet.energy = 100 : myPet.energy += 10;
                        break;
                    case 3 when myPet.filth > 0:
                        Console.WriteLine();
                        myPet.hunger = myPet.hunger >= 90 ? myPet.hunger = 100 : myPet.hunger += 10;
                        myPet.energy = myPet.energy >= 90 ? myPet.energy = 100 : myPet.energy += 10;
                        myPet.filth = myPet.filth <= 20 ? myPet.filth = 0 : myPet.filth -= 20;
                        break;
                    case 4:
                        Console.WriteLine();
                        myPet.hunger = myPet.hunger >= 90 ? myPet.hunger = 100 : myPet.hunger += 10;
                        myPet.energy = myPet.energy >= 90 ? myPet.energy = 100 : myPet.energy += 10;
                        myPet.filth = myPet.filth >= 90 ? myPet.filth = 100 : myPet.filth += 10;
                        break;

                }

            }
        }

    }
}
