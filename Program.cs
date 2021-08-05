using System;
using System.Collections.Generic;

namespace JurassicPark
{

    class Dinosaur
    {
        public string DinoName { get; set; }
        public string DietType { get; set; }
        public int EnclosureNumber { get; set; }
        public int WhenAcquired { get; set; }
        public int Weight { get; set; }

    }

    class Program
    {

        static void Main(string[] args)
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

            var userChoice = Console.ReadLine().ToUpper();

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
                    Console.WriteLine("This is not a valid entry. Action cancelled.");
                    return 0;
                }
            }

            if (userChoice == "A")

            {

                var dinosaur = new Dinosaur();

                dinosaur.DinoName = PromptForString("Dinosaur Name: ");
                dinosaur.DietType = PromptForString("Diet Type - (O)mnivore/(C)arnivore: ");
                dinosaur.EnclosureNumber = PromptForInteger("Enclosure Number: ");
                dinosaur.WhenAcquired = PromptForInteger("Date Acquired (FORMAT: MMDDYYYY): ");
                dinosaur.Weight = PromptForInteger("Weight: ");

                //Dinosaur.Add(dinosaur);
            }

            else

            {

                Console.WriteLine("Action Canceled!");

            }

            //-Once entered, prompt to add another(Y)es and(N)o.

            //- If(Y)es, loop through fields to add
            //- If(N)o, return to menu */



        }


    }
}