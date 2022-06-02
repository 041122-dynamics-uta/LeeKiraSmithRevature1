using System.Data.SqlClient;
using P1Models;

namespace P1Repository
{
    public class P1MapperClass
    {//create a method that will transfer the data from the customer list
        internal CustomerTable DboToCustomer(SqlDataReader reader)
        {
            CustomerTable m = new CustomerTable
            {
                CustomerId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Email = (string)reader[3],
                Password = (string)reader[4],
            };
            return m;
        }    

        //method to transfer data from store list
        public StoreClass DboToStore(SqlDataReader reader)
        {
            StoreClass s = new StoreClass
            {
                StoreId = (int)reader[0],
                StoreName = (string)reader[1],
                City = (string)reader[2],
                //Inventory = (int)reader[3],
            };
            return s;
        }
    
        public ProductClass DboToProduct(SqlDataReader reader)
        {
            ProductClass atl = new ProductClass
            {
                ProductId = (int)reader[0],
                Name = (string)reader[1],
                Description = (string)reader[2],
                Price = (int)reader[3],
            };
            return atl;
        }
    }

}

