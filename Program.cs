using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //TriangleSolver t = new TriangleSolver();
            p.Go();
            //Console.ReadKey();
        }

        void Go()
        {
            int menu = ValidateMenuSelection();

            while (menu == 1)
            {
                int side1 = 1;
                int side2 = 1;
                int side3 = 1;

                Console.WriteLine("Please enter the lengths of 3 sides of your triangle. Each length should be an integer within 1-100: ");
                side1 = ValidateUserInput();
                side2 = ValidateUserInput();
                side3 = ValidateUserInput();
                Console.WriteLine();

               // Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));


                menu = ValidateMenuSelection();

            }
        }


        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {

                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");


                Console.WriteLine("Please select an option by entering a number ");
                userInput = Console.ReadLine();

                if (userInput == "1" || userInput == "2")
                {
                    validMenuSelect = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please enter a number from 1 and 2. ");

                }
            }


            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput()
        {
            int sideLength = 1;
            bool isValid = false;

            while (isValid == false)
            {
                string userInput = Console.ReadLine();

                bool result = int.TryParse(userInput, out sideLength);

                if (result == false)
                {
                    Console.WriteLine("That is not a valid input, please input an integer within 1-100");
                }
                else if (sideLength > 100)
                {
                    Console.WriteLine("The length cannot be greater than 100, please try again");
                }
                else
                {
                    isValid = true;
                }
            }
            return sideLength;
        }
    }


}
