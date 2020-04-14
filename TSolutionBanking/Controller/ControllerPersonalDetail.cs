using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSolutionBanking.Controller
{
    class ControllerPersonalDetail
    {
        BankingEntities db;

        public ControllerPersonalDetail()
        {
            db = new BankingEntities();
        }

        public void addPersonalDetail(Customer customer)
        {
            db.Customers.Add(customer);
        }

        public void updatePersonalDetail(Customer customer)
        {
            customer =(Customer)db.Customers.Where(cust => cust.AccountNumber == customer.AccountNumber);
            db.Entry(customer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<Customer> GetPersonalDetail()
        {
            return db.Customers.ToList();
        }

        public void DeletePersonalDetail(Customer customer)
        {
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
    }
}
