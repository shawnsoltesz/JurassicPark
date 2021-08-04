# JurassicPark

P - Create a console application to manage the data related to the collection of dinosaurs in my zoo. The application will track the following information about each dinosaur: Name, Diet Type, When Acquired, Weight and the Enclosure Number where the animal resides. In order to create and maintain the data entered, the application should allow for the following functionality - add, view and remove a dinosaur from the zoo's collection, as well as the ability to view a summary of all dinosaurs at one time. In the event that a dinosaurs enclosure number changes, the functionality to update this data is also a requirement, as well as the ability to to quit the application when work is complete.

E -

1. Add :
   [Name] - Dino name
   [DietType] - This will be "carnivore" or "herbivore"
   [WhenAcquired] - This will default to the current time when the dinosaur is created
   [Weight] - How heavy the dinosaur is in pounds.
   [EnclosureNumber] - the number of the pen the dinosaur is in

2. WhenAcquired needs to be a non-editable {Date.Time} variable when the entry is made

3. Need to allow for entries to be made with blank fields (null) without issue

4. [MethodDescription]
   (Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.) **TBD**

D -

[Class] - Create a class to represent your dinosaurs. The class should have the following properties:

[Name] - Dino name
[DietType] - This will be "carnivore" or "herbivore"
[WhenAcquired] - This will default to the current time when the dinosaur is created {Date.Time} but non-editable (startdate = Convert.ToDateTime("12/25/2008");)
[Weight] - How heavy the dinosaur is in pounds. (int parsed)
[EnclosureNumber] - the number of the pen the dinosaur is in

[MethodDescription]
Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.

    To be built under the class, but need an output option. Name "Collection"

[Remove] - allow user to search for dinosaur by name, confirm deletion, and remove upon confirmation.

[View] - A list of entries sorted by {Date.Time} stamp using LINQ Sort By/Then By

[Transfer] - Only prompt user with a new Enclosure Number to be edited. Other fields are non-editable and should not be included.

Data Storage - Data will be stored a List<Dinosaur>.

A -

When the console application runs, it should let the user choose one of the following actions:

[(A)dd]
This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.

[(R)emove]
This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.

[(S)ummary]
This command will display the number of carnivores and the number of herbivores.

[(T)ransfer]
This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.

[(V)iew] - **use LINQ OrderBy and ThenBy**
This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.

[Quit]
This will stop the program

A -

Create a class: Dinosaur

[Name] - Dino name
[DietType] - This will be "carnivore" or "herbivore"
[WhenAcquired] - This will default to the current time when the dinosaur is created
[Weight] - How heavy the dinosaur is in pounds. (int.parse)
[EnclosureNumber] - the number of the pen the dinosaur is in

Set up a welcome screen menu with the following options:

---

Welcome to Jurassic Zoo  
 ****\*\*\*\*****
Dinosaur Collection Application

---

What action would you like to complete?

1. (A)dd
2. (R)emove
3. (S)ummary
4. (T)ransfer
5. (V)iew
6. (Q)uit

If user selects (A)dd

- Prompt user with Dinosaur variables (accept a blank entry and enter null)

If user selects (R)emove

- Prompt use with Console.Read line to collect dinosaur name
  -If match
