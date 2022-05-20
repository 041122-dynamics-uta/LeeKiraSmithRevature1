using System;
using System.Collections.Generic;
using P1Business;
using P1Models;
using P1Repository;
using System.Data.SqlClient;

namespace P1project
{
    class Program
    {
        //the entrypoint for ANY C# program is the static void main () method.
        static void Main(string[] args)
        {
            //Store s = new Store();
            CustomerTable newCustomer = new CustomerTable();
            P1RepoClass prc = new P1RepoClass ();
            P1BusinessClass pbc = new P1BusinessClass(prc);
            
            Console.WriteLine("Welcome to CookieCrumble!");

        //First we need a menu to give new customers, returning customers, and admin a place to start. Start with a greeting then give them an option to select from menu. // 
         
        //While Loop to initialize program
            
            bool loopContinue = false;// this is to tell the user to correctly enter the correct value format
        
            while (loopContinue == false)

            {

                //User Prompt
                Console.WriteLine("Please Select From the Following Options:");
                Console.WriteLine("\n 1 Employee \n 2 for Existing Customer \n 3 for New Customer \n 4 to Exit Program ");
                
                int menuOption = Convert.ToInt32(Console.ReadLine());
                
                // Use TryParse when reading the user input. This will avoid an 
                // Exception if the user types a letter for example.
                if ( menuOption < 4) //used equal sign to allow exit with choice 4 - took it out. The range was throwing off menu options. 
                {
                    switch (menuOption)
                    {
                        case 1:
                            Console.WriteLine("Enter Employee Verification Code:");
                            int employeeVerify = Convert.ToInt32(Console.ReadLine());
                            
                            if(employeeVerify == 1234)
                             {
                                 loopContinue = true;
                                 
                             }
                            else
                            {
                                Console.WriteLine("You do not have access. Returning to main menu.");
                                
                            }                   
                        break;

                        case 2:
                        //Choice 2 enters into Existing Customer Interface
                            Console.WriteLine("Please enter your email");
                            string uEmail = Console.ReadLine();
                            Console.WriteLine("Please enter your password");
                            string uPassword = Console.ReadLine();

                            //newCustomer = pbc.newCustomer(FirstName);
                            //want it to display first name of user.
                            Console.WriteLine($"Welcome back, {uEmail} ");
                            //Console.WriteLine($"Welcome back, {FirstName} ");
                            loopContinue = true;
                        break;

                        case 3: //Something is throwing an infinite loop. Not connected to db currently. 
                        //Choice 3 enters into New Customer Interface
                        Console.WriteLine("Please enter your Customer Id");
                            int CustomerId = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your First Name");
                            string FirstName = Console.ReadLine();
                            Console.WriteLine("Please enter your Last Name");
                            string LastName = Console.ReadLine();
                            Console.WriteLine("Please enter your Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Please enter your Password");
                            string password = Console.ReadLine();

                            newCustomer = pbc.newCustomer(FirstName,LastName,email,password);
                            
                            //Enter email and password into Database
                            
                            //newCustomer =  (FirstName, LastName, email, password);

                            Console.WriteLine($"Hey, {newCustomer.FirstName} {newCustomer.LastName}. Welcome!");

                            loopContinue = true;

                        break;

                              
                        case 4:
                        //Exits program
                        loopContinue = true;
                        Console.WriteLine("Bye!");
                        break;

                        default:
                        Console.WriteLine("That is not a valid option. Please try again.");
                        break;
                    }
                    
                } 

           }
       //Store Location
      /*  CookieCrumbleLocation a = new CookieCrumbleLocation();
        //int loc = CookieCrumbleLocation();
        bool CookLocLoop = true;

        while ( CookLocLoop == false )
        
        {
            int CookLocLoop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose:");

            switch (CookLocLoop)
            {
                case 1:
                    Console.WriteLine("CookieCrumble Atlanta");
                    CookLocLoop = true;
                    break;
                        
                case 2:
                    Console.WriteLine("CookieCrumble Houston");
                    CookLocLoop = true;
                    break;

                case 3:
                    Console.WriteLine("CookieCrumble Los Angeles");
                    CookLocLoop = true;
                    break;
            }
            //loc = CookieCrumbleLocation();
        }
            */

            Console.WriteLine("What would you like to do today?");

      //Store 
        Store s = new Store();
         int action = menuAction();

            while (action != 0 )
            {
                Console.WriteLine("You typed" + action);

                switch ( action)
                {
                //Add to inventory
                 case 1:   
                    Console.WriteLine("Make a new cookie.");   
                        String cookieFlavor = "";
                        String cookieDescription = "";
                        Decimal cookiePrice = 0;
                    
                    Console.WriteLine("What is the cookie flavor? Snickerdoodle, Butter, Ginger Snap etc.");
                    cookieFlavor = Console.ReadLine();

                    Console.WriteLine("How would you describe this cookie?");
                    cookieDescription = Console.ReadLine();

                    Console.WriteLine("What is the cookie price?");
                    cookiePrice = int.Parse(Console.ReadLine());

                    Cookie newCookie = new Cookie (cookieFlavor, cookieDescription, cookiePrice);
                    s.CookieList.Add(newCookie);

                    printInventory(s);
                    break;

                //Add to cart
                case 2: 

                    Console.WriteLine("You choose to add a delicious cookie to your shopping cart");
                    printInventory (s);
                    Console.WriteLine ("Which item would you like to add? (number)");
                    int cookieChosen = int.Parse(Console.ReadLine());

                    s.ShoppingList.Add(s.CookieList[cookieChosen]);

                    printShoppingCart(s);

                    break;
                //Checkout
                case 3:
                    printShoppingCart (s);
                    Console.WriteLine("Your cookie cost is : "+ s.Checkout());
                    break;

                default:
                    break;

                }
                action = menuAction();
            }

        }
        //was private
      private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cookies you have selected to buy");
             for(int i = 0; i < s.ShoppingList.Count; i++)
            {
                //Console.WriteLine("Cookie: " + c.Flavor + " "+ c.Price +" ");
                Console.WriteLine("Cookie #: " + i + " " + s.ShoppingList[i]);
            }   
        }
        public static void printInventory(Store s)
        {
            for(int i = 0; i < s.CookieList.Count; i++)
            {
                //Console.WriteLine("Cookie: " + c.Flavor + " "+ c.Price +" ");
                Console.WriteLine("Cookie #: " + i + " " + s.CookieList[i]);
            }
        }
        //was static public int
        static public int menuAction()
        {
            int choice = 0;
            Console.WriteLine("\n To exit - type (0). \n Customize A Cookie - type (1). \n Add Cookie to your cart - type (2). \n To checkout - type (3).");

            choice = int.Parse( Console.ReadLine());
            return choice;        
        }   

/*
            Cookie c = new Cookie();
            Cookie d = new Cookie ("Sugar Cookie", 10.00m);
            Cookie e = new Cookie ("Choclate Chip", 10.00m);
            Cookie f = new Cookie ("Peanut Butter", 10.00m);
            Cookie g = new Cookie ("Oatmeal Cookie", 10.00m);
            Cookie h = new Cookie ("Shortbread Cookie", 10.00m);
            Console.WriteLine("Cookie choice:" + " " + d.Flavor + " for " + d.Price);
            Console.WriteLine("Cookie choice:" + " " + f.Flavor + " for " + f.Price);
            
            Store s = new Store();
            s.ShoppingList.Add(d);
            s.ShoppingList.Add(f);
            decimal total = s.Checkout ();
            Console.WriteLine("Your CookieCrumble total is " + total);
          */  

      
      
    
      
      } 

    }   


      
