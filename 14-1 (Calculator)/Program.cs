﻿using System;

namespace _14_1__Calculator_
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain program, prompt user for equation, give example for correct format.
            Console.WriteLine("Calculator to add, subtract, multiply, or divide two numbers. ");
            Console.Write("Please type out equation to be calculated. (Example: 1 + 1) ");

            //put equation into string
            string equation = Console.ReadLine();

            //create new instance of calculator class using equation string as input.
            Calculator calculator = new Calculator(equation);

            //initiate method from calculator class to calculate equation
            calculator.Calculate();


            Console.ReadLine();

        }
    }
}
