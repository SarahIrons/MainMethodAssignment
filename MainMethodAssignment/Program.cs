using System;

//MAIN METHOD ASSIGNMENT

//Perform these actions and create a console app that includes the following:


//Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.

//Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

//Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
namespace MainMethodAssignment
{
    public class Program
    {
        public static int inputNumber { get; set; }
        public static object line3 { get; private set; }

        private static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number here, and we will perform a math operation with it: ");
            int inputA = Int32.Parse(Console.ReadLine()); //gets input as a string and stores it
                                                          //this takes user input and converts to integer.
            var operatorObject = new MathMethod(); //this instantiates the class. This will allow return of the math methods.
            operatorObject.MathMethodA(inputA);



            //this takes user number and runs the addition method (adding 4) and displays the result to user.
            // In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine("Please enter a decimal here, and we will perform a math operation with it: ");

            decimal input2 = decimal.Parse(Console.ReadLine());

            operatorObject.MathMethodB(input2);//this takes a decimal value and displays it back to the user.

            Console.WriteLine("Put a number here and we will square it: ");
            string input3 = Console.ReadLine();
            operatorObject.MathMethodC(input3);
            // //this takes the decimal and converts it to string and displays it back to user.
            //Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.

        }
    }
}



