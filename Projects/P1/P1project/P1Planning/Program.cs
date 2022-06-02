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
            ProductClass newProductClass = new ProductClass();
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
       //View a store location
        bool SloopContinue = false;// this is to tell the user to correctly enter the correct value format
        
            while (SloopContinue == false)
            {
       // Console.WriteLine("What would you like to do today?");
       Console.WriteLine("\n View a list of stores -- type 1\n View a list of products -- type 2\n View Order -- type 3\n Exit -- type 4");
       //Console.WriteLine(" 1 Yes \n 2 No \n 3 to Exit Program");
       Console.WriteLine("\n");
                int StoreOption = Convert.ToInt32(Console.ReadLine());
                if ( StoreOption < 4) //used equal sign to allow exit with choice 4 - took it out. The range was throwing off menu options. 
                {
                    switch (StoreOption)
                    {
                        case 1:
                          List<StoreClass> store = pbc.StoreClassList();
                         foreach (StoreClass sc in store)
                        
                        Console.WriteLine($"Store {sc.StoreId} is {sc.StoreName} located in {sc.City}");
                         
                                 //SloopContinue = true;
                                  
                                  
                        break;

                        case 2:
                        //Add Products
                        Console.WriteLine($"Products available -----");
                        SloopContinue = true;
                        break;

                        case 3:
                        // Add order history
                        Console.WriteLine($"Order history ------");
                        SloopContinue = true;
                        break;


                        case 4:
                          SloopContinue = true;
                        Console.WriteLine("Bye!");
                        break;

                        default:
                        Console.WriteLine("That is not a valid option. Please try again.");
                        break;
                    }
                }
                }
            
                 //Choose a store
                 List<StoreClass> stores = pbc.StoreClassList();
                 
                 int Schoice = StoreChoice();
                 //int Schoice = Convert.ToInt32(Console.ReadLine());
                 while (Schoice != 0 )
                 {
                 Console.WriteLine ($"You selected store location" + " " + Schoice );
                 
                 switch ( Schoice)
                 {
                     case 12:
                     
                     
                     Console.WriteLine($"CookieCrumbleAtlanta");
                     List<ProductClass> products = pbc.ProductClassList();
                     //string productR = Convert.ToString(Console.ReadLine());
                     //Keep getting an error about unable to cast object of type "System. Int32 to type 'System.String'
                       foreach (ProductClass atl in products){
                        
                        Console.WriteLine($"{atl.Name} -- {atl.Description} --- {atl.Price}");
                       // int item = Convert.ToInt32(Console.ReadLine());
                       }
                       
                       
                       
                     //Console.WriteLine($"The products availabe are  {atl.Name}, {atl.Description}, {atl.Price}");
                     //string 
                     //View inventory
                     //Select inventory
                     //Add to cart

                     break;
                     

                     case 14:
                     Console.WriteLine($"CookieCrumble Los Angeles");

                     break;

                     case 16:
                     Console.WriteLine($"CookieCrumble Houston");
                     
                     break;

                     default:
                     break;
                 }
        

                Schoice = StoreChoice();
    
                 }     
             
               
                        
            

       
       
       
       
       
       
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

          //  Console.WriteLine("What would you like to do today?");

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
       static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cookies you have selected to buy");
             for(int i = 0; i < s.ShoppingList.Count; i++)
            {
                //Console.WriteLine("Cookie: " + c.Flavor + " "+ c.Price +" ");
                Console.WriteLine("Cookie #: " + i + " " + s.ShoppingList[i]);
            }   
        }
        static void printInventory(Store s)
        {
            for(int i = 0; i < s.CookieList.Count; i++)
            {
                //Console.WriteLine("Cookie: " + c.Flavor + " "+ c.Price +" ");
                Console.WriteLine("Cookie #: " + i + " " + s.CookieList[i]);
            }
        }
        static int StoreChoice()
        {
            int Schoice = 0;
           // Console.WriteLine("\n Which location would you like to shop at?");
            //Console.WriteLine("\n");
            Console.WriteLine("\n For \n CookieCrumble Atlanta - type (12). \n CookieCrumble Los Angeles - type (14) \n CookieCrumble Houston - type (16) \n To Exit - type (0)");

            //int Schoice = Convert.ToInt32(Console.ReadLine());
            Schoice = int.Parse( Console.ReadLine());
            return Schoice;
        }
        //was static public int
        static int menuAction()
        {
            int choice = 0;
            Console.WriteLine("\n To exit - type (0). \n Customize A Cookie - type (1). \n Add Cookie to your cart - type (2). \n To checkout - type (3).");

            choice = int.Parse( Console.ReadLine());
            return choice;        
        }   
    }
    }
//}



      
