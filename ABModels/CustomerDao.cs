using System;

namespace ABModels
{
    /// <summary>
    /// The methods that we need to save and retrieve data from database.
    /// </summary>
    public interface CustomerDao
    {
         public int register(Customer customer);
         public int update(Customer customer);
         // Retrieve the Customer object from the database.
         public Customer validateCustomer(Login login);
    }
}