using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSolutionBanking.Controller
{

  public  class CustomerController
    {
        BankingEntities db;

        public CustomerController()
        {

            db = new BankingEntities();
            Console.WriteLine(db);
        }

        public CustomerController(Customer customer)
        {
            EditCustomerDetail(customer);
        }

        public List<Customer> GetCustomerDetails()
        {
            return db.Customers.ToList();
        }
        public Task<List<Customer>> Query(Customer customer)
        {
            return Task.Run(()=> {
                var query =
             from cust in db.Customers
             where cust.CustomerNo == customer.CustomerNo
             select cust;

                return query.ToList();
              
            });
        }

        public Task<List<Customer>> QueryAccountNo(String AccountNumber)
        {
            return Task.Run(() => {
                var query =
             from cust in db.Customers
             where cust.AccountNumber == AccountNumber
             select cust;

                return query.ToList();

            });
        }
        public async void EditCustomerDetail(Customer  customer)
        {
          
            foreach (Customer cust in await Query(customer))
            {
                

                cust.Balance = customer.Balance;
                cust.Firstname = customer.Firstname;
                cust.Lastname = customer.Lastname;
                cust.Othername = customer.Othername;
                cust.Phone = customer.Phone;
                cust.Username = customer.Username;
                cust.Password = customer.Password;

            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }

           public void DeleteCustomerDetail(Customer customer)
           {

               db.Customers.Remove(customer);
           }

           public void AddCustomerDetail(Customer customer)
           {

               db.Customers.Add(customer);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
             


               
        }
    
    }
}
