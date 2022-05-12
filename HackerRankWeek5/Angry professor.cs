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
     * Complete the 'angryProfessor' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY a
     */

    public static string angryProfessor(int k, List<int> a)
    {   //int a=the arrival times of the students
        //int k=the threshold number of students 
        //int count=students on time
        //YES means class is cancelled
        //NO means class is going
        int count=0;
        for(int i=0; i<a.Count; i++)
        {
            if(a[i]<=0)
            {
                count++;
            }
        }
        if(count>=k)
            return "NO";
        else
            return "YES";
    }

}
// lambda expression => arrow
//vadim showed a one line method
//List<int> howMany = a.Where(x => x<=0).ToList();
//if(howMany.Count>=k){
   // return "NO";
//}
//return "YES";
//return (a.Where(x => x<= 0).ToList().Count >=k) >= ? "NO" : "YES"
//return (a.FindAll(x => x <= 0).Count() >= ? "NO" : "YES")
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = Result.angryProfessor(k, a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}