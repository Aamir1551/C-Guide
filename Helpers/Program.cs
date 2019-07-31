using System;


//IMPORTANT ----------------------------------------------------------------------------------------
using System.Collections.Generic; // ------------------ INclude this line of code, to be able to use lists
//IMPORTANT ----------------------------------------------------------------------------------------

namespace Helpers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Printing to console is achieved via the console class. (Console is a class)
            //Console.writeline(some-text) -- writes to the screen
            //Console.readline() -- reads from the screen

            Console.WriteLine("Im writing"); //--console.writeline also moves onto next line

            Console.Write("Your turn, you write something: "); //console.write -- does not move onto next line
            string someInput = Console.ReadLine();
            //console.readline took in data from user and stored it in the variable someInput

            //TO rewrite the userinput back into the screen we can do:
            Console.WriteLine(someInput); // --this will write back exacty what the user entered
            //even better would be:
            Console.WriteLine("You wrote: {0}", someInput); //if someInput = "heyyy u", this writes back "You wrote: heyyy u"  


            //forloops are done via
            //int i=0 --declares a variable called i of type int
            //i<10 -- is the condition for which needs to be true, only then will it run
            //i++ means that every time the for-loop code is ran, i is increased by 1
            for(int i=0; i<10; i++) 
            {
                Console.WriteLine(i);
            }
            //This forloop prints all the numbers from 0-9

            //below shows usage of while loop
            //try to see if you can guess what is happening
            string myText = "*";
            while(myText.Length != 10) //myText.length returns the length of myText (so the length of the string it is storing)
            {
                Console.WriteLine(myText);
                myText = myText + "*";
            }

            //below is an example of how if/else statements are used to control temperature in a house
            int houseTemperature = 30;
            bool fanIsOn = false;

            if(houseTemperature > 35)
            {
                if(fanIsOn == false)
                {
                    Console.WriteLine("Why is the fan on!!!!, turn it off");
                }
                else
                {
                    Console.WriteLine("Increase fan speed!!!!");
                }
            }
            else if(houseTemperature < 5)
            {
                if(fanIsOn == true)
                {
                    Console.WriteLine("Its so cold, why is fan on!!!!");
                }
                else
                {
                    Console.WriteLine("Turn on heaters");
                }
            } else
            {
                Console.WriteLine("Ahhh nice temperature");
            }

            //using Lists

            //creating list of strings
            List<string> myAwesomeList = new List<string>(); //remember to add the namespace System.Collections.Generic
            //to add to list, we do
            myAwesomeList.Add("orange");
            //to get an item from list, we do
            Console.WriteLine(myAwesomeList[0]); //this prints out the first element of the list

            //using if/else statements in list

            if(myAwesomeList[0] == "cars")
            {
                Console.WriteLine("The first element is cars");
            }
            else if(myAwesomeList[0] == "ice cream")
            {
                Console.WriteLine("the first element is ice cream");
            }
            else if(myAwesomeList[0] == "orange")
            {
                Console.WriteLine("the first element is orange");
            }
            else
            {
                Console.WriteLine("I give up");
            }

            //remember our list so far only contains one item, if you tried myAwesomeList[1] -- you WILL get an index error
            //This is because you are picking an item in a list, even though their is no item in position 1. (there is an item in position 0)


            /// Finally, play around with the code to your needs and if any help required
            /// then use the following resources to guide you:
            /// https://www.tutorialspoint.com/csharp/
            /// https://www.youtube.com/watch?v=lisiwUZJXqQ

        }
    }
}
