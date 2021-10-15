using System;

namespace Calcualtor
{
    public class CalConsole
    {
        public static void Main(string[] args)
        {
            //start the apCALConsole.dllp with a menu
            Menu();

            //Menu method with 2 options
            static string Menu()
            {
                Console.Write(" \t\t\t Choose an option: \n");
                Console.Write(" \t\t\t \n");
                Console.Write("Press 1 to start the calculator \n");
                Console.Write("Press 2 to exit the app \n");
                while (true)
                {
                    string Navigate;
                    Navigate = Console.ReadLine();

                    switch (Navigate)
                    {
                        case "1":
                            Calculator();
                            break;
                        case "2":

                            Exit();
                            break;
                    }

                    //keep the menu on 
                    Menu();

                    static void Calculator()
                    {

                        double result = 0;
                        bool hasArray = false;
                        double firstNumber = 0;
                        double secondNumber = 0;

                        Console.WriteLine("Welcome to my calculator:");

                        Console.WriteLine("CHoose an action ");
                        Console.WriteLine("Press 1 for Addition");
                        Console.WriteLine("Press 2 for Subtraction");
                        Console.WriteLine("Press 3 for Multiplication");
                        Console.WriteLine("Press 4 for Division \n");

                        string operation = Console.ReadLine();
                        if (operation == "1")
                        {

                            Console.WriteLine("Do you want to sum two numbers press enter, For More than two numbers press 5 for addition");
                            string answer = Console.ReadLine();
                            if (answer == "5")
                            {
                                hasArray = true;
                            }
                        }
                        if (hasArray)
                        {
                            Console.Write("Enter the total fo the numbers you want to sum, then press those numbers  ");

                        }

                        if (operation == "2")
                        {
                            Console.WriteLine("Do you want to substract two numbers press enter, For More than two numbers press 6 please!");
                            string answer = Console.ReadLine();
                            if (answer == "6")
                            {
                                hasArray = true;
                            }
                            if (hasArray)
                            {
                                Console.Write("Enter the total fo the numbers you want to substract, then press those numbers  ");

                            }
                            else
                            {
                                Console.WriteLine("Enter your first number:");
                                firstNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter your second number:");
                                secondNumber = Convert.ToDouble(Console.ReadLine());

                            }

                        }

                        //choice of  operations
                        switch (operation)

                        {
                            case "1":
                                {
                                    if (!hasArray)
                                    {
                                        result = Add(firstNumber, secondNumber);
                                    }
                                    else
                                    {

                                        int arraylength = Convert.ToInt32(Console.ReadLine());

                                        double[] arrOfNumbers = new double[arraylength];

                                        for (int i = 0; i < arrOfNumbers.Length; i++)
                                        {

                                            arrOfNumbers[i] = Convert.ToInt32(Console.ReadLine());

                                        }
                                        result = Add(arrOfNumbers);

                                    }
                                    break;
                                }
                            case "2":
                                if (!hasArray)
                                {
                                    result = Sub(firstNumber, secondNumber);
                                }
                                else
                                {
                                    int arraylength = Convert.ToInt32(Console.ReadLine());

                                    double[] arrOfNumbers = new double[arraylength];

                                    for (int i = 0; i < arrOfNumbers.Length; i++)
                                    {

                                        arrOfNumbers[i] = Convert.ToInt32(Console.ReadLine());

                                    }
                                    result = Sub(arrOfNumbers);
                                }
                                break;

                            case "3":
                                {
                                    result = Mult(firstNumber, secondNumber);
                                    break;
                                }
                            case "4":
                                {
                                    //forbiden div by zero
                                    if (secondNumber == 0 && firstNumber == -Math.Abs(firstNumber))
                                    {

                                        Console.WriteLine(firstNumber);
                                        result = double.NegativeInfinity;

                                        Console.WriteLine("divide a negative number by zero will result negative infinty!");
                                    }
                                    else if (secondNumber == 0)
                                    {
                                        Console.WriteLine(firstNumber);
                                        result = double.PositiveInfinity;
                                        Console.WriteLine("divide a negative number by zero will result negative infinty!");
                                    }
                                    else
                                    {
                                        result = Div(firstNumber, secondNumber);
                                    }

                                    break;

                                }

                            default:
                                Console.WriteLine("Wrong choice!! try again");
                                Menu();
                                break;
                        }

                        Console.WriteLine("The result is {0}", result);
                        Console.ReadLine();

                    }
                }

            }

        }

        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;

        }
        //overload addition method
        public static double Add(double[] myArray)
        {

            double result = 0;
            foreach (double n in myArray)
            {
                result += n;
            }
            return result;

        }

        public static double Sub(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        //overload sub method
        public static double Sub(double[] myArray)
        {
            // set result to the first number in myArray
            double result = myArray[0];
            //start from 1 to not sub the first number twice 
            for (int n = 1; n < myArray.Length; n++)
            {
                result -= myArray[n];

            }

            return result;

        }

        public static double Mult(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        public static double Div(double firstNumber, double secondNumber)
        {

            double result = firstNumber / secondNumber;
            return result;
        }
        //exit app method
        static void Exit()
        {

            Console.Write("to exit the app please, press the enter key");

            Console.ReadLine();
            System.Environment.Exit(1);
        }

    }

}
