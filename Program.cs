using System;

namespace JurassicPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class: Dinosaur

            //[Name] - Dino name
            //[DietType] - This will be "carnivore" or "herbivore"
            //[WhenAcquired] - {Date.Time entry}
            //[Weight] - How heavy the dinosaur is in pounds. (int.parse)
            //[EnclosureNumber] - the number of the pen the dinosaur is in

            //Set up a welcome screen menu with the following options:

            Console.WriteLine("");
            Console.WriteLine("         Welcome to Jurassic Zoo        ");
            Console.WriteLine("             ****************           ");
            Console.WriteLine("      Dinosaur Collection Application   \n");


            Console.WriteLine("-*-*-*-*-*-*-*-*-*-MENU-*-*-*-*-*-*-*-*-*-\n");
            Console.WriteLine("What action would you like to complete?\n");

            Console.WriteLine("1. (A)dd a new dinosaur to the collection");
            Console.WriteLine("2. (C)ollection review of all dinosaurs");
            Console.WriteLine("3. (R)emove a dinosaur from the collection");
            Console.WriteLine("4. (S)ummary of collections' Omnivores and Carnivores");
            Console.WriteLine("5. (T)ransfer a dinosaur's enclosure pen");
            Console.WriteLine("6. (V)iew dinosaurs in collection and date acquired");
            Console.WriteLine("7. (Q)uit and close application\n");

            Console.WriteLine("Please input the letter from the menu and press ENTER.\n");

            //Prompt user to enter their selection. Convert to Upper

            var userChoice = Console.ReadLine().ToUpper();
        }
    }
}
