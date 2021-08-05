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
[WhenAcquired] - This will default to the current time when the dinosaur is acquired using created {Date.Time}
[Weight] - How heavy the dinosaur is in pounds. (int parsed)
[EnclosureNumber] - the number of the pen the dinosaur is in

[MethodDescription] aka [Collection]
Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative. **TBD**To be built under the class, but need an output option. Name "Collection"

[Remove] - allow user to search for dinosaur by name, confirm deletion, and remove upon confirmation.

[View] - - **use LINQ OrderBy and ThenBy**
This command will show the all the dinosaurs in the list, ordered by WhenAcquired.
Use {Date.Time} stamp If there aren't any dinosaurs in the park then print out a message that there aren't any.

[Transfer] - Only prompt user with a new Enclosure Number to be edited. Other fields are non-editable and should not be included.

Data Storage - Data will be stored a List<Dinosaur>.

A -

Create display for Jurassic Dinosaur Zoo
Create a menu with the following actions:

1. [(A)dd a dinosaur to the collection]

2. [(C)ollection review of all dinosaurs]

3. [(R)emove a dinosaur from the collection]

4. [(S)ummary of collections' Omnivores and Carnivores]

5. [(T)ransfer a dinosaur's enclosure pen]

6. [(V)iew dinosaurs in collection and date acquired]

7. [(Q)uit] application and close

A -

Create a class: Dinosaur

[Name] - Dino name
[DietType] - This will be "carnivore" or "herbivore"
[WhenAcquired] - {Date.Time entry}
[Weight] - How heavy the dinosaur is in pounds. (int.parse)
[EnclosureNumber] - the number of the pen the dinosaur is in

Add a method Description to your class to print out a description of the dinosaur to include all the properties. **TBD format**Create an output format of your choosing.

**???**(Keep track of dinosaurs in list called Dinosaurs)

Create a welcome screen for application
Create a menu for application functionality options
Prompt user to enter their selection. Convert to Upper

If user selects (A)dd

- Prompt user with Dinosaur class variables to complete. Indicate to users that all fields must be entered or addition will be cancelled.
  - [Name] - Dino name
  - [DietType] - This will be "carnivore" or "herbivore"
  - [WhenAcquired] - {Date.Time entry}
  - [Weight] - How heavy the dinosaur is in pounds. (int.parse)
  - [EnclosureNumber] - the number of the pen the dinosaur is in
- One entered, return to menu

If user selects (C)ollection

- **TBD**Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.

If user selects (R)emove

- Prompt use with Console.Read line to collect dinosaur name to be removed.
  -Include LINQ "Contains" expression to help return results.
  -If no match, Console.WriteLine message "No such dinosaur exists in our collection." - If match, Console.WriteLine matching dinosaur name - If match, display message for user to confirm desire to remove dinosaur with (Y)es/(N)o menu option. Convert to Upper
  -Console.Read user input string to collect Y or N
  -If Y, remove dinosaur from list and return to menu
  -If No, cancel action and return to menu

If the user selects (S)ummary

- Generate a report counting the number of dinosaurs - grouping counts of omnivores and carnivores
  -Use LINQ expression count
  - Return counts in Console.WriteLine
    -If there are no dinosaurs in the collection, Console.WriteLine "There are no dinosaurs in our collection."
- Return to menu

If the user selects (T)ransfer

- Prompt use with Console.Read line to collect dinosaur name to be removed.
  -Include LINQ "Contains" expression to help return results.
  - -If no match, Console.WriteLine message "No such dinosaur exists in our collection." and return to menu
  - If match, Console.WriteLine "Please enter {dinosaur} new enclosure pen"
    - Console.Read to collect user input

If the user selects (V)iew

- Generate a report of all dinosaurs in the collection
  -Use LINQ OrderBy and ThenBy function to arrange dinosaurs based on {Date.Time} stamp when dinosaur was created
  -If there are no dinosaurs in the collection, Console.WriteLine "There are no dinosaurs in our collection."
- Return to menu

If the user selects (Q)uit

- Console.WriteLine "Have a roarin' great day at Jurrasic Zoo!"
- Terminate and close application
