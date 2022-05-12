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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     
     1. Seprate the data they already have a list of arrarys . 
     What do I need to collect?
     - determine the id of the most frequently sighted type (count list)
     
     2. What do I need to return?
     -if more than one 1 type has been spotted.      
     Return the smallest of their ids. (sort list)
     
     greater than 5 less than 100,000
     The array entered can only be type 1-5
     */

    public static int migratoryBirds(List<int> arr)
    {  
/*Seprate the data they already have a list of arrarys . 
What do I need to collect?
- determine the id of the most frequently sighted type 
*/
/*These are my variable instanciations */
        int frequentBird = arr[0];
        int currentType = arr[0];
        int topCount = 1;
        int currentCount= 0;
        arr.Sort();
        
/*What do I need to return?
-if more than one 1 type has been spotted.      
Return the smallest of their ids. (sort list) */
        for (int a =0; a< arr.Count; a+= currentCount)
        {

                currentCount = 0;
                
                for (int b=0; b<arr.Count; b++) //nested for loop
                {
                    if(arr[a] == arr[b])
                    {
                        currentCount++;
                    }
                    if(topCount < currentCount)
                    {
                        frequentBird = arr[a]; 
                        topCount++;
                    }
                }
        
        }
        return frequentBird;
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
