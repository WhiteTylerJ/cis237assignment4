using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            //Add 10 hard coded droids to the collections
            droidCollection.Add("Carbonite", "Protocol", "Silver", 10);                              //Protocol $350
            droidCollection.Add("Vanadium", "Astromech", "Gold", true, true, true, false, 2);        //Astromech $315
            droidCollection.Add("Carbonite", "Janitorial", "Bronze", false, true, true, true, true); //Janitorial $240
            droidCollection.Add("Quadranium", "Utility", "Silver", true, true, true);                //Utility $255
            droidCollection.Add("Carbonite", "Astromech", "Bronze", false, false, false, false, 1);  //Astromech $145
            droidCollection.Add("Vanadium", "Utility", "Silver", true, false, true);                 //Utility $190
            droidCollection.Add("Carbonite", "Protocol", "Bronze", 1);                               //Protocol $125
            droidCollection.Add("Quadranium", "Astromech", "Gold", true, true, true, true, 10);      //Astromech $740
            droidCollection.Add("Vanadium", "Utility", "Gold", false, false, true);                  //Utility $155
            droidCollection.Add("Vanadium", "Janitorial", "Bronze", true, true, true, true, true);   //Janitorial $295

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;
                    //Sort droids by model
                    case 3:
                        break;
                    //sort droids by cost
                    case 4:                                            
                        break;
                    
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }


        }
    }
}
