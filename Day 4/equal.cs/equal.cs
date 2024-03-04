using System;  // Importing the System namespace

using System;  // Importing the System namespace

public class Exercise1  // Declaration of the Exercise1 class
{
    public static void Main()  // Entry point of the program
    {
        int int1, int2; // Declaration of integer variables int1 and int2
        Console.Write("\n\n"); // Printing new lines
        Console.Write("Check whether two integers are equal or not:\n"); // Displaying the purpose of the program
        Console.Write("-------------------------------------------"); // Displaying a separator
        Console.Write("\n\n"); // Printing new lines
        Console.Write("Input 1st number: "); // Prompting user to input the first number
        int1 = Convert.ToInt32(Console.ReadLine());  // Reading the first input number from the user

        Console.Write("Input 2nd number: "); // Prompting user to input the second number
        int2 = Convert.ToInt32(Console.ReadLine());  // Reading the second input number from the user

        if (int1 == int2)  // Checking if int1 is equal to int2
            Console.WriteLine("{0} and {1} are equal.\n", int1, int2); // Printing a message if the numbers are equal
        else
            Console.WriteLine("{0} and {1} are not equal.\n", int1, int2); // Printing a message if the numbers are not equal


