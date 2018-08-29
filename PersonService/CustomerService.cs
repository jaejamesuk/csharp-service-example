using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonService
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            return PopulateCustomer();
        }

        public Customer GetCustomerByID(int id)
        {
            //Customer result = null;
            //foreach (Customer cos in PopulateCustomer())
            //{
            //    if (cos.Id == id)
            //    {
            //        result = cos;
            //    }
            //}

            //return result;

            return PopulateCustomer().SingleOrDefault(x => x.Id == id);
        }

        public List<Customer> PopulateCustomer()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Firstname = "Jae",
                    Lastname = "Toole",
                    Street = "43 Rossefield Terrace",
                    Postcode = "LS13 3SD"
                },
                new Customer
                {
                    Id = 2,
                    Firstname = "John",
                    Lastname = "Doe",
                    Street = "64 Zoo Ln",
                    Postcode = "HA4 3PQ"
                },
                new Customer
                {
                    Id = 3,
                    Firstname = "Lorem",
                    Lastname = "Ipsum",
                    Street = "10 Lorem Street",
                    Postcode = "LI3 4PT"
                }
            };
            return customers;
        }
    }
}
