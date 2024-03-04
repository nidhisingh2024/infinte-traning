
using System;  // Importing necessary namespace

public class Exercise4  // Declaration of the Exercise4 class
{
    public static void Main()  // Main method, entry point of the program
    {
        int[] arr1 = new int[100];  // Declaration of an integer array 'arr1' with size 100
        int[] arr2 = new int[100];  // Declaration of another integer array 'arr2' with size 100
        int i, n;  // Declaration of variables 'i' and 'n'

        // Display a message about copying elements from one array to another
        Console.Write("\n\nCopy the elements from one array into another array:\n");
        Console.Write("------------------------------------------------------\n");

        // Prompt the user to input the number of elements to be stored in the array
        Console.Write("Input the number of elements to be stored in the array: ");
        n = Convert.ToInt32(Console.ReadLine());  // Read the number of elements from the user and store it in 'n'

        Console.Write("Input {0} elements in the array:\n", n);  // Prompt the user to input 'n' elements

        // Loop to read 'n' elements from the user and store them in the array 'arr1'
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);  // Prompt for input element number
            arr1[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and store it in the array 'arr1'
        }

        // Copy elements of the first array 'arr1' into the second array 'arr2'
        for (i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];  // Copy each element of 'arr1' to the corresponding index in 'arr2'
        }

        // Display the elements stored in the first array 'arr1'
        Console.Write("\nThe elements stored in the first array are:\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr1[i]);  // Output each element of 'arr1'
        }

        // Display the elements copied into the second array 'arr2'
        Console.Write("\n\nThe elements copied into the second array are:\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr2[i]);  // Output each element of 'arr2'
        }

        Console.Write("\n\n");  // Extra newline for formatting
