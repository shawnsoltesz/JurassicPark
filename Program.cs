﻿using System;
using System.Collections.Generic;
using System.Linq;

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

            DisplayGreeting();

            var keepGoing = true;

            while (keepGoing)
            {

                var userChoice = Console.ReadLine().ToUpper(); //won't allow to be packaged with the DisplayGreeting method

                if (userChoice == "Q")
                {
                    // They said quit, so set our keepGoing to false
                    keepGoing = false;
                }

                else
                if (userChoice == "A")
                {

                    var dinosaur = new Dinosaur();

                    dinosaur.DinoName = PromptForString("ADD: Dinosaur Name: ");
                    dinosaur.DietType = PromptForString("ADD: Diet Type - (O)mnivore/(C)arnivore: ");
                    dinosaur.EnclosureNumber = PromptForInteger("ADD: Enclosure Number: ");
                    dinosaur.WhenAcquired = PromptForInteger("Date Acquired (ADD: FORMAT: MMDDYYYY): ");
                    //int DateTime = dinosaur.WhenAcquired;
                    //DateTime dt = DateTime.Parse(Convert.ToString("MMDDYYYY"));

                    dinosaur.Weight = PromptForInteger("ADD: Weight: ");

                    dinosaurs.Add(dinosaur);
                }

                keepGoing = true;

                if (userChoice == "C")

                {
                    //**TBD**Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.
                }

                if (userChoice == "R")

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
                DisplayGreeting();

                userChoice = Console.ReadLine().ToUpper(); //won't allow to be packaged with the DisplayGreeting method
            }
        }
    }
}