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
    }
}