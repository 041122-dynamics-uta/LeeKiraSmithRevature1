using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
              Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            return userName;
        }

        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
            return "Greetings " + name + ". ";
        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
             Double num = Convert.ToDouble(Console.ReadLine());

            return num;
        }

        public static int GetAction()
        {
           // throw new NotImplementedException("GetAction() is not implemented yet");
            int action = Convert.ToInt32(Console.ReadLine());

            return action;
        }

        public static double DoAction(double x, double y, int action)
        {
            //throw new NotImplementedException("DoAction() is not implemented yet");
            switch(action)
            {
              case 1:
                return x + y;
              case 2:
                return Math.Abs(x - y);
              case 3:
                return x * y;
              case 4:
                return x / y;
              default:
                throw new FormatException("Wrong Format");  
            }
        }
    }
}
