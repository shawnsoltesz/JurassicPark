# JurassicPark

P - Create a console application to manage the collection of dinosaurs in my zoo. The application will track the following information about each dinosaur: Name, Diet Type, When Acquired, Weight and the Enclosure Number where the animal resides. In order to create and maintain the data entered, the application should allow for the following functionality - add, view and remove a dinosaur from the zoo's collection, as well as the ability to view all dinosaurs at one time. In the event that a dinosaurs enclosure number changes, the functionality to update this data is also required. Lastly, functionality to quit the application should be implemented as well.

E -

D -

[Class] - Create a class to represent your dinosaurs. The class should have the following properties:

[Name] - Dino name
[DietType] - This will be "carnivore" or "herbivore"
[WhenAcquired] - This will default to the current time when the dinosaur is created {Date.Time}
[Weight] - How heavy the dinosaur is in pounds.
[EnclosureNumber] - the number of the pen the dinosaur is in

[Method Description]
Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.

Keep track of your dinosaurs in a List<Dinosaur>.

A -

When the console application runs, it should let the user choose one of the following actions:

[View]
This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.

[Add]
This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.

[Remove]
This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.

[Transfer]
This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.

[Summary]
This command will display the number of carnivores and the number of herbivores.

[Quit]
This will stop the program
