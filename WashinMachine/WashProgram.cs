using System;
using System.Collections.Generic;
using System.Text;

namespace WashinMachine
{
    class WashProgram
    {
       // public int WashProgarm { get; set; }
        int choice; 
        public void ProgramWash() // a Method named ProgramWash
        {
            bool onOff = Program.PowerState; // Calls on the bool named powerState and renames it in this part of the program to onOff
            if (onOff == true) // and if statement, that when true will run its contents
            {
                Console.WriteLine("Press 1 for White wash\n Press 2 for Black wash\n Press 3 for Mixed wash"); // A method that displays the given message, in this case which program to choose
                choice = int.Parse(Console.ReadLine()); // Converts the variable ¨Choice¨ content/input to integer.
                switch (choice) // Switch case that reads which option you take. 
                {
                    case 1:
                        Console.WriteLine("White clothes wash initiated\n Done in 55 minutes"); // A method that displays the given message, an initiate message with a time until done
                        break; 
                    case 2:
                        Console.WriteLine("Black clothes wash initiated\n Done in 47 minutes"); // A method that displays the given message, an initiate message with a time until done
                        break;
                    case 3:
                        Console.WriteLine("Mixed clothes wash initiated\n Done in 72 minutes"); // A method that displays the given message, an initiate message with a time until done
                        break;
                    default:
                        Console.WriteLine("Error"); // A method that displays the given message
                        break;
                }

            }
        }
    }
}
