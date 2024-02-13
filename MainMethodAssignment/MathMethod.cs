using System;
using System.Collections.Generic;
using System.Text;


namespace MainMethodAssignment
{//Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
    internal class MathMethod
    {
        private int x;

        public void MathMethodA(int inputNumber)
        {
            Console.WriteLine("Your number plus four is: " + inputNumber + 4);
        }


        public void MathMethodB(decimal number1)
        {
            decimal number2 = 2.3m;
            decimal number3 = number1 * number2;
            Console.WriteLine(
                 "{0:N2} x {1:N2} = {2:N2}",
                 number1, number2, number3);

        }

        public void MathMethodC(string x)
        {
            //convert string to integer 
            int xAsNumber = int.Parse(x);
            int sqNum = xAsNumber * xAsNumber;
                //find squared number 
            
                Console.WriteLine("Your number squared is: " + sqNum);
        }

   
    }
}


