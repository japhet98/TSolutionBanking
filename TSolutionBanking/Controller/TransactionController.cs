using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSolutionBanking.Controller
{
    class TransactionController
    {
        BankingEntities db;
        public TransactionController()
        {
            db = new BankingEntities();
          

        }
       
        public void AddTransaction(Transaction transaction)
        {
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public void EditTransaction(Transaction transaction)
        {

        }

        public void DeleteTransaction(Transaction transaction)
        {
            db.Transactions.Remove(transaction);
            db.SaveChanges();
        }

        public List<Transaction> GetTransactions()
        {
            return db.Transactions.ToList();
        }


    }
}
