using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
             byte b = 255;
        sbyte sb = -128;
        int num = 2147483647;
        uint ui = 4294967295;
        short sh = -32768;
        ushort us = 65535;
        float f = 31.1289f;
        double d = 12.1231250;
        char c = 'N';
        bool both = true;
        string tx = "I control text";
        string ts = "23";
        decimal dec = 3.001002003m;
        long l = 9223372036854775807;
        ulong ul = 18446744073709551615;


        Console.WriteLine(PrintValues(b));
        Console.WriteLine(PrintValues(sb));
        Console.WriteLine(PrintValues(num));
        Console.WriteLine(PrintValues(ui));
        Console.WriteLine(PrintValues(sh));
        Console.WriteLine(PrintValues(us));
        Console.WriteLine(PrintValues(f));
        Console.WriteLine(PrintValues(d));
        Console.WriteLine(PrintValues(c));
        Console.WriteLine(PrintValues(both));
        Console.WriteLine(PrintValues(tx));
        Console.WriteLine(PrintValues(ts));
        Console.WriteLine(PrintValues(dec));
        Console.WriteLine(PrintValues(l));
        Console.WriteLine(PrintValues(ul));
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");
                switch(obj)
             {
                case string tx:
                    tx = "Data Type => String";
                    return tx;

                default: 
                    break;
             }
            return null;

        }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
           // throw new NotImplementedException($"StringToInt() has not been implemented");
             int i;
            bool mybool = Int32.TryParse(numString, out i);

            if (mybool)
            {
                return i;
            }
            else  
            {
                return null;
            }
        
    }// end of class
}// End of Namespace
