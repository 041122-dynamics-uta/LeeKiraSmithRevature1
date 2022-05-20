using P1Models;
using P1Repository;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace P1Business;

public class P1BusinessClass
{
    //inject the dependency into the class
    public P1RepoClass _repo {get; set;}
    public P1BusinessClass(P1RepoClass r)
    {
        this. _repo = r;
    }
          public List<CustomerTable> CustomerList()
        {
        List<CustomerTable> ml = _repo.CustomerList();
            return ml;
        }
    //public CustomerTable FirstName (string FirstName)
    //{
      //  CustomerTable cl = _repo.newCustomerTable(FirstName);
       // return cl;
    //}
    public CustomerTable newCustomer(string FirstName, string LastName, string email, string password)
    {
        //pass the new data to repo layer to insert into Db.
        //query to make sure this name doesn't exist
       // CustomerTable m = new CustomerTable(FirstName, LastName, email, password);
        //return m;
        CustomerTable m = _repo.newCustomerTable(FirstName, LastName, email, password);
        return m;
    }

}

  
        

    public class Store
    {
            public List<Cookie> CookieList {get; set;}
            public List<Cookie> ShoppingList {get; set;}

            public Store()
            {
                CookieList = new List<Cookie>();
                ShoppingList = new List<Cookie>();
            }
            public decimal Checkout()
        {
        //initialize the total cost
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
            //Adds up the total cost by incrementing
            //totalCost= totalCost + c.Price; can also be written like
            totalCost += c.Price;
            }
        //This will empty out the shopping list
            ShoppingList.Clear ();

            return totalCost;
        }
    }

    public class Location
    {
        public List<CookieCrumbleLocation> StoreLocationList {get; set;}

        public Location()
        {
            StoreLocationList = new List<CookieCrumbleLocation>();
        } 
    }

   /* public class Customer {
    // public NewCustomer(string FirstName, string LastName, string Email, string Password)
    //{
        //pass new data to repo layer to insert into the Db.
        //query anyone with this name
      //  Customer m = P1RepoClass.NewCustomer(FirstName, LastName, Email, Password);
        //return m;
    }
    }*/

                    
                
