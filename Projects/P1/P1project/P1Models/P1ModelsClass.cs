using System.Data.SqlClient;
using System.Collections.Generic;
namespace P1Models;

    public class CustomerTable
    {
        //Customer Table
        public int CustomerId {get; set;} = 0;
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? Address {get; set;} 
        public string? City {get; set;}
        public string? State {get; set;}
        public string? Country{get; set;}
        public int PostalCode {get; set;} =0;
        public int Phone {get; set;} = 0;
        public string? Email {get; set;}
        public string? Password {get; set;}

        public  CustomerTable ()
        {
            FirstName = "nothing yet";
            LastName = "nothing yet";
            Email = "nothing yet";
            Password = "nothing yet";
        }

        public CustomerTable (string a, string b, string c, string d)
        {
            FirstName = a;
            LastName = b;
            Email = c;
            Password = d;
        }
    }
    public class ProductClass
    {
        // --- PRODUCT TABLE 
        public int ProductId {get; set;}
        public int StoreId {get; set;}
        public string? Name {get; set;}
        public string? Description {get; set;}
        public int Price {get; set;}
        //If I set int to decimal will i have to cast it?
        public int Quantity {get; set;}
        public DateTime DateCreated {get; set;} = DateTime.Now; 


    }
    public class Cookie
    {
        public string Flavor { get; set;}
        public string Description {get; set;}
        public decimal Price { get; set;}

        public Cookie ()
        {
            Flavor = "Oh no! You didn't choose a flavor!";
            Price = 0.00M;
        }

        public Cookie (string a, string b, decimal c)
        {
            Flavor = a;
            Description = b;
            Price = c;
        }
        
        override public string ToString() //all methods are tostring so you have to override it to avoid the error message 
        {
            return "Flavor: " + Flavor + " Description: " + Description + " Price: $" + Price;
        }
    }

    public class CookieCrumbleLocation 
    {
        public string StoreLocation {get; set;}

        public CookieCrumbleLocation ()
        {
            StoreLocation = "Select store location";
        } 
        
        public CookieCrumbleLocation (string a)
        { 
            StoreLocation = a;
        }

        override public string ToString()
        {
            return "Store Location: ";
        }
    }
    public class StoreClass
    {
    // --  STORE TABLE -- with the following columns
        public int StoreId {get; set;}
        public string? Address {get; set;}
        public string? City {get; set;}
        public int PostalCode {get; set;}
        public int Phone {get; set;}
        public string? Email {get; set;}
        public string? StoreName {get; set;}

        //public string StoreLocation {get; set;} maybe use this instead of having to call on all these objects just for the store location.(address,city,postalcode)
    }


    public class Inventory
    {
        // -=- JOINS TABLE  remember store <-> product relationship is many to many... .create a JOINS TABLE
        public int InventoryId {get; set;}
        public int InventoryNumber {get; set;}
        public int ProductId {get; set;}
        public int StoreId {get; set;}
        public DateTime DateCreated {get; set;} = DateTime.Now;

    // public string StoreInventory {get; set;}
    }
    

   
  




   



