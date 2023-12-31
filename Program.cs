//THIS CODE IS WRRITEN BY: IAN KURT G. VALENCIA | BSCS I-E1 | OCTOBER 5, 2023


/*This line imports the System namespace, which contains many of the
basic classes and methods that are used in C# programming.*/
using System;
namespace SumOfTwoNumbers;
//This declares a public class called SumOfTwoNumbers.
public class SumOfTwoNumbers
{
    //The Main() method is the entry point for the program, and it is where execution begins.
    public static void Main()
    {
        /*This declares three floating-point variables (a, b, and sum)
        and two string variables (firstNumberInput and secondNumberInput).*/
        decimal a, b, sum;
        string firstNumberInput, secondNumberInput;

        /*This line writes the message "Sum of Two Numbers in C# Using Console"
        to the console, followed by a newline character.*/
        Console.WriteLine("Sum of Two Numbers in C# Using Console\n");

        /*This line writes the message "Enter the first number:" to the console,
        and then reads the user's input into the firstNumberInput variable.*/
        Console.Write("Enter the first number: ");
        firstNumberInput = Console.ReadLine();

        /*This line tries to parse the firstNumberInput string into a floating-point number and
        store the result in the a variable. If the parse is successful, the firstNumberParsed variable
        is set to true, otherwise it is set to false*/
        bool firstNumberParsed = decimal.TryParse(firstNumberInput, out a);

        //This loop will continue to iterate until the user enters a valid floating-point number.
        while (!firstNumberParsed)
        {
            Console.WriteLine("Invalid input. Please try again.");
            firstNumberInput = Console.ReadLine();
            firstNumberParsed = decimal.TryParse(firstNumberInput, out a);
        }
        //This line is similar to the previous one, but it reads the second number from the user.
        Console.Write("Enter the second number: ");
        secondNumberInput = Console.ReadLine();

        //This line is also similar to the previous one, but it tries to parse the second number.
        bool secondNumberParsed = decimal.TryParse(secondNumberInput, out b);

        /*This loop is also similar to the previous one, but it continues to
        iterate until the user enters a valid floating-point number for the second number.*/
        while (!secondNumberParsed)
        {

            Console.WriteLine("Invalid input. Please try again.");
            secondNumberInput = Console.ReadLine();
            secondNumberParsed = decimal.TryParse(secondNumberInput, out b);
        }
        //This line calculates the sum of the two numbers and stores the result in the sum variable.
        sum = a + b;

        /*This line writes the message "The sum of the {0} and {1} is: {2}..." to the console,
        followed by the value of the sum variable and a newline character.*/
        Console.WriteLine("The sum of the {0} and {1} is: {2}...\n", a, b, sum);

        //This line writes the message "End of Program" to the console, followed by a newline character.
        Console.WriteLine("End of Program\n");

        //This line pauses the console until the user presses a key.       
        Console.ReadKey();
    }
}
