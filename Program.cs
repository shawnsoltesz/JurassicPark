using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{

    class Dinosaur
    {
        public string DinoName { get; set; }
        public string DietType { get; set; }
        public int EnclosureNumber { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }

    }

    class Program
    {

        public static void DisplayGreeting()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("         Welcome to Jurassic Zoo        ");
            Console.WriteLine("             ****************           ");
            Console.WriteLine("      Dinosaur Collection Application   \n");

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-MENU-*-*-*-*-*-*-*-*-*-\n");
            Console.WriteLine("What action would you like to complete?\n");

            Console.WriteLine("COLLECTION MANAGEMENT\n");

            Console.WriteLine("(A)dd a new dinosaur to the collection");
            Console.WriteLine("(R)emove a dinosaur from the collection");
            Console.WriteLine("(T)ransfer a dinosaur's enclosure pen\n");

            Console.WriteLine("REPORTS\n");

            Console.WriteLine("(C)ollection details of all dinosaurs");
            Console.WriteLine("(S)ummary of diet types");
            Console.WriteLine("(V)iew dinosaurs and date acquired\n");
            Console.WriteLine("(Q)uit application\n");

            Console.WriteLine("Please input the letter from the menu and press ENTER.\n");

        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                //Console.WriteLine("This is not a valid entry. Action cancelled.");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            var dinosaurs = new List<Dinosaur>();

            DateTime WhenAcquired = DateTime.Now;



            var keepGoing = true;

            while (keepGoing)
            {


                DisplayGreeting();

                var userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "Q")
                {
                    keepGoing = false;
                    Console.WriteLine("Have a roarin' great day at Jurrasic Zoo!\n\n\n\n");
                    break;
                }
                else if (userChoice == "A")
                {
                    var dinosaur = new Dinosaur();
                    //DateTime dt = DateTime.Parse(Convert.ToString("MMDDYYYY"));

                    dinosaur.DinoName = PromptForString("ADD: Dinosaur Name: ");
                    dinosaur.DietType = PromptForString("ADD: Diet Type - (O)mnivore/(C)arnivore: ");
                    dinosaur.EnclosureNumber = PromptForInteger("ADD: Enclosure Number: ");
                    Console.WriteLine($"Date Acquired {DateTime.Now}");
                    dinosaur.Weight = PromptForInteger("ADD: Weight: ");

                    dinosaurs.Add(dinosaur);

                }
                else if (userChoice == "C")

                {
                    foreach (var dinosaur in dinosaurs)

                    {
                        Console.WriteLine("The following dinosaurs are in our collection:\n");
                        Console.WriteLine($"Dino Name: {dinosaur.DinoName}");
                        Console.WriteLine($"Diet Type - (O)mnivore or (C)arnivore: {dinosaur.DietType}");
                        Console.WriteLine($"Enclosure Number: {dinosaur.EnclosureNumber}");
                        Console.WriteLine($"When Acquired: {dinosaur.WhenAcquired}");
                        Console.WriteLine($"Weight: {dinosaur.Weight}");
                    }

                    if (dinosaurs == null)

                    {
                        Console.WriteLine("There are no dinosaurs in our collection.");

                    }

                }
                else if (userChoice == "R")

                {
                    var nameToSearchFor = PromptForString("REMOVE: Dinosaur Name ");

                    Dinosaur foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.DinoName == nameToSearchFor);

                    if (foundDinosaur == null)

                    {
                        Console.WriteLine("No such dinosaur in our collection");
                    }

                    else
                    {
                        Console.WriteLine($"REMOVE: {foundDinosaur.DinoName} ");

                        var confirm = PromptForString("Are you sure? [Y/N] ").ToUpper();

                        if (confirm == "Y")
                        {
                            dinosaurs.Remove(foundDinosaur);
                        }
                    }

                }
                else if (userChoice == "S")

                {

                    var numOmnivore = dinosaurs.Count(dinosaur => dinosaur.DietType == "O");
                    var numCarnivore = dinosaurs.Count(dinosaur => dinosaur.DietType == "C");

                    if (numCarnivore == 0 && numOmnivore == 0)

                    {
                        Console.WriteLine("There are no dinosaurs in our collection.");
                    }

                    else if (numCarnivore != 0 || numOmnivore != 0)
                    {
                        Console.WriteLine("Here's a summary of our collection's Diet Types:");
                        Console.WriteLine($"Carnivore: {numCarnivore}");
                        Console.WriteLine($"Herbivore: {numOmnivore}");
                    }

                }
                else if (userChoice == "T")

                {
                    var nameToSearchFor = PromptForString("TRANSFER: Dinosaur Name ");

                    Dinosaur foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.DinoName == nameToSearchFor);

                    if (foundDinosaur == null)

                    {
                        Console.WriteLine("No such dinosaur in our collection");
                    }

                    else
                    {
                        Console.WriteLine($"TRANSFER: {foundDinosaur.DinoName} ");

                        var confirm = PromptForString("Are you sure? [Y/N] ").ToUpper();

                        if (confirm == "Y")
                        {

                            foundDinosaur.EnclosureNumber = PromptForInteger("TRANSFER: Enter new Enclosure Number: ");
                        }

                        Console.WriteLine($"{foundDinosaur.DinoName} has been transferred to {foundDinosaur.EnclosureNumber}");

                    }

                }
                else if (userChoice == "V")
                {
                    Console.WriteLine($"VIEW: {foundDinosaur.DinoName} ");

                }

            }
        }
    }
}
}