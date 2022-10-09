using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {

        #region Number Finders

        static bool findNumbers(string calcFunction, out int num1, out int num2)
        {
            Console.WriteLine("Enter 2 integers to " + calcFunction);
            var userNum1 = Console.ReadLine();
            var userNum2 = Console.ReadLine();

            if (int.TryParse(userNum1, out int num1Temp) && int.TryParse(userNum2, out int num2Temp))
            {
                num1 = num1Temp;
                num2 = num2Temp;
                return true;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                num1 = 0;
                num2 = 0;
                return false;
            }
        }

        #endregion

        #region Equation Method / Main Method
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var userInput = Console.ReadLine();
            var calculator = new Calculator();

            switch (userInput)
            {
                case "1":
                    var success = findNumbers("add", out int num1, out int num2);
                    if (success == true)
                    {
                        Console.Write($"{num1} + {num2} = ");
                        Console.Write(calculator.Add(num1, num2));
                    }
                    break;

                case "2":
                    success = findNumbers("subtract", out int subnum1, out int subnum2);
                    if (success == true)
                    {
                        Console.Write($"{subnum1} - {subnum2} = ");
                        Console.Write(calculator.Subtract(subnum1, subnum2));
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var multiplyNumber1 = Console.ReadLine();
                    var multiplyNumber2 = Console.ReadLine();

                    if (int.TryParse(multiplyNumber1, out int multiNum1) && int.TryParse(multiplyNumber2, out int multiNum2))
                    {
                        Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                        Console.Write(calculator.Multiply(multiNum1, multiNum2));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    #endregion

    #region Calculator Return Method

    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
    #endregion

}