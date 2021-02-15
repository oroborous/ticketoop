using System;
using System.Linq;

namespace TicketOOP.Models
{
    public class Menu
    {
        // constructor
        public Menu()
        {
            Console.WriteLine("------- MENU --------");
            Console.WriteLine("(R)ead the ticket data");
            Console.WriteLine("(C)reate Tickets");
            Console.WriteLine("(Q)uit");
        }

        // methods
        public char GetUserInput()
        {
            char selection;

            Console.Write("?");
            while (!IsValidInput(Console.ReadKey(true).KeyChar, out selection))
            {
                Console.WriteLine($"Invalid input: {selection}");
                Console.WriteLine();
                Console.WriteLine("Please enter (R)ead, (C)reate, or (Q)uit");
                Console.Write("?");
            }

            Console.WriteLine();
            return selection;
        }
        private bool IsValidInput(char input, out char selection)
        {
            char[] validValues = { 'R', 'r', 'C', 'c', 'Q', 'q' };

            selection = Char.ToUpper(input);
            if (validValues.Contains(input))
            {
                return true;
            }

            return false;
        }
    }
}



//UNITTEST 1
//{
//    // arrange
//    //    instantiate the class
//    // act
//    //    execute the method under test (eg. IsValidInput)
//    //       pass in 'r'
//    // assert
//    //    validate that the expected output is correct
//    //       expect true
//}

//UNITTEST 2
//{
//    // arrange
//    //    instantiate the class
//    // act
//    //    execute the method under test (eg. IsValidInput)
//    //       pass in 'x'
//    // assert
//    //    validate that the expected output is correct
//    //       expect false
//}