using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
        int i: the starting day number
        int j: the ending day number
        int k: the divisor
    Returns
    int: the number of beautiful days in the range
     */

    public static int reverseNumber(int num)
    {
            /* To reverse a number in C# set int reverse to 0.
             If the number is greater then 0 you can send that number through a loop. 
             The loop would start with int remainder = Number % 10. Then reverse by reverse= (reverse * 10) + remainder; 
             Take that Number and divide it by 10*/
            
        int revNum = 0;
        while (num > 0)
        {
            revNum = revNum * 10 + num % 10;
            num /= 10;
        }
        
        return revNum;
    }
    
            /* set int count equal to 0.
            int day = int i (starting day number)
            if int i/ int day is less than or equal to j/the ending day number increment by 1. 
            Take that result and do a reverse by subtracting the day by the reverse number and then dividing int k/the divisor if the result is equal to 0 increment count by 1 if not return count.
            
            You can also use .reverse*/
    public static int beautifulDays(int i, int j, int k)
    {
        int count = 0;
        for (int day = i; day <= j; day++)
        {
            int revNum = reverseNumber(day);
            if ((day - revNum) % k == 0)
            {
                count++;
            }
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
