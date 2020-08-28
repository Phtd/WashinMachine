using System;

namespace WashinMachine
{
    class Program
    {
        private static bool powerState; // Makes the bool variable named powerState
        public static bool PowerState { get { return powerState; } set { powerState = false; } } // Makes it possible to change the value in the private bool powerState later on


        public static void Main(string[] args)
        {
            WashProgram wash = new WashProgram(); // Calls the WashProgram class and gives it a new name, wash, in this class.
            powerState = true; //Gives the variable powerState a value so it's always true

            while (true) // A while loop, that, while true, will continue to run
            {
               if (powerState == true) // and if statement, that when it is true, will run its content
               {
                   Console.WriteLine("Please choose a program"); // A console.writeline that will printout/display the given message in its content
                   wash.ProgramWash(); // calls on the function wash and runs it
                   
               }
                Console.ReadKey(); // Makes it so you have to press a key in order to proceed in the program

            }
        }
    }
}
