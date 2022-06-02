using System;
using System.Data.SqlClient;
using P1Models;


namespace P1Repository;
public class P1RepoClass
{
    public P1MapperClass _mapper {get; set;}
    string connectionString = $"Server=tcp:leekirasmithserver.database.windows.net,1433;Initial Catalog=CookieCrumble;Persist Security Info=False;User ID=LeeKiraSmithDB;Password=Munchkin2012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


    public P1RepoClass()
    {
    this._mapper = new P1MapperClass ();
    }



    public List <CustomerTable> CustomerList()
    {
        string myQuery1 = "SELECT FirstName From Customer;";
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Connection.Open();
            SqlDataReader results = command.ExecuteReader();

            List<CustomerTable> cl = new List<CustomerTable>();
            while (results.Read())
            {
                //map the current table row to a member class objects.
                CustomerTable m = this._mapper.DboToCustomer(results);
                cl.Add(m);
            }
            query1.Close(); //You must close so that other methods can access it.
            return cl;
        }
    }

    public CustomerTable newCustomerTable(string FirstName, string LastName, string email, string password)
    {
       string myQuery2 = $"INSERT INTO Customer (FirstName, LastName, email, password) VALUES(@f, @l, @e, @p);";
        using (SqlConnection query2 = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(myQuery2, query2);
            //command.Parameters.AddWithValue ("@cId", 2);
            command.Parameters.AddWithValue ("@f", FirstName);
            command.Parameters.AddWithValue("@l", LastName);
            command.Parameters.AddWithValue("@e", email);
            command.Parameters.AddWithValue("@p", password);
            command.Connection.Open();//opens connection to database
            int results = command.ExecuteNonQuery(); //conducting of query
            query2.Close();//always close the query

            if(results == 1)
            {
            CustomerTable m = new CustomerTable
            {
                 CustomerId = 0, 
                 FirstName = FirstName,
                 LastName = LastName,
                 Email = email,
                Password = password
            };
            return m;
            }
            return new CustomerTable();
        }
    }

     public List<StoreClass> StoreClassList()
    {
        string myQuery3 = "SELECT * FROM Store;";
//using block creates SqlConnection
//SqlConnection is the object that communicates with the Db.
        using (SqlConnection query3 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the object to open a connection and send the query.
            SqlCommand command = new SqlCommand (myQuery3, query3);
            command.Connection.Open();
            SqlDataReader results = command.ExecuteReader();
//query the Repo Database for the list of stores
//use the mapper to transfer the values in to Stores objects in a List<StoreClass>
            List<StoreClass> sc = new List<StoreClass>();
            while (results.Read())
            {
                sc.Add(this._mapper.DboToStore(results)); // the row send in to the reader to be mapped
            }
            query3.Close();
            return sc;
        }
    }

    
     public List<ProductClass> ProductClassList()
    {
        string myQuery4 = "SELECT * FROM Product;";
//using block creates SqlConnection
//SqlConnection is the object that communicates with the Db.
        using (SqlConnection query4 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the object to open a connection and send the query.
            SqlCommand command = new SqlCommand (myQuery4, query4);
            command.Connection.Open();
            SqlDataReader results = command.ExecuteReader();
            
//query the Repo Database for the list of stores
//use the mapper to transfer the values in to Stores objects in a List<StoreClass>
            List<ProductClass> atl = new List<ProductClass>();
            while (results.Read())
            {
                atl.Add(this._mapper.DboToProduct(results)); // the row send in to the reader to be mapped
            }
            query4.Close();
            return atl;
        }
    }

    
            


        }
    


  //List available Stores


           /* List<CustomerTable> cl = new List<CustomerTable>();
            while (results.Read())
            {
                //map the current table row to a member class objects.
                CustomerTable m = this._mapper.DboToCustomer(results);
                cl.Add(m);
            }
            query1.Close(); //You must close so that other methods can access it.
            return cl;*/
        //}
    //}
//}

/*public nCustomer newCustomer(string FirstName, string LastName, string Email, string Password)
{
    string myQuery1 = $"INSERT INTO _Members VALUES(@f, @l, @e, @p);";
    // this using block creates SqlConnection. The object that communicates with Db.
    using (SqlConnection query1 = new SqlConnection(connectionString))
    {
        //The SqlCommand object uses the query text along with the SqlConnection object to input data
        SqlCommand command = new SqlCommand(myQuery1, query1);
        command.Parameters.AddWithValue("@f", FirstName);
        command.Parameters.AddWithValue("@l", LastName);
        command.Parameters.AddWithValue("@e", Email);
        command.Parameters.AddWithValue("@p", Password);
        command.Connection.Open();//open the connection to the Db
        int results = command.ExecuteReader();//actually conducts the query
         query1.Close();//You must close the connection for any other method to access 
        return myQuery1;

        if(results ==1)
        {
        nCustomer m = new nCustomer{
            CustomerId = 100, 
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            Password = Password
            
        }; 
        return m;
        }
        return null;
        };
       
    }*/
