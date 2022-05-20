using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetconsole_SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it sweet, salty, or sweet & salty? Let's see");
            //Tariq and Valdehim helped me fixed some of the querks so I didn't have to change my for loop. 
            //
            //Valdehim helped me set my number list
            //1.Get the start and stop numbers (the range) from the user.
            //User input – to set range  (n1 – n2)
            //First number (n1)
            //Second number (n2)
            //Console.WriteLine - to inform the user on what we need 
            //Console.ReadLine - to receive input from user
            Console.WriteLine("To get started we will need to set a range of numbers.");
            Console.WriteLine("What should be our first number?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What should be our second number?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Numbers printed per line from user's input            ex: n3       =   n1, n2, n3
            Console.WriteLine("How many numbers do you want printed per line?");
            int numberPerLine = Convert.ToInt32(Console.ReadLine());

            int lineBreak = 0;
            int difference = secondNumber - firstNumber;
            //Now I need to print the numbers in groups per line specified by the users input
            //Do I need a list? 
            //I need an array
           // IEnumerable <int> numbersList = Enumerable.Range(firstNumber, difference);


            //Using a for loop since the number of iterations is set/known by the user
            //First need to declare the variables above to instruct the for loop on how to 
        
        int[] numbersList = Enumerable.Range(firstNumber, difference+1).ToArray();
        //+1 on difference to include the last number in the count

        int sweet =0;
        int salty = 0;
        int sweetsalty = 0;
    //used a for but changing to a foreach loop
    for (int i = 0; i < numbersList.Length; i++)
    {
        if  (lineBreak == numberPerLine) 
        {
            Console.WriteLine();
            lineBreak = 0;
            //Console.Writeline leave blank for space
            //lineBreak to break the loop for the achieved numberPerLine entered by the user.
        }
        if (numbersList[i] % 3 == 0 && numbersList[i] % 5 == 0)
        {
            Console.Write("Sweet & Salty ");
            sweetsalty++;
            
        }
        else if ( numbersList[i] % 3 == 0)
        {
            Console.Write("Sweet ");
            sweet++;
        }
        else if (numbersList[i] % 5 == 0)
        {
            Console.Write( "Salty ");
            salty++;
        }           
        else
        {
            Console.Write($"{numbersList[i]} ");  // curly braces because its a variable. without it it would just print the variable not the value. allows you to use variable inside of string.
        }
        ++lineBreak;
    }

//print to the screen how many sweet, salty, sweet&salty
        Console.WriteLine();
        Console.WriteLine("The amount of Sweets present");
        Console.WriteLine(sweet);

        Console.WriteLine("The amount of Salty present");
        Console.WriteLine(salty);

        Console.WriteLine("The amount of Sweet&Salty present");
        Console.WriteLine(sweetsalty);
        }
    }
}
