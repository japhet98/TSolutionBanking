using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSolutionBanking.Models
{
 public  class Customer
    {
        public string CustomerNo { get; set; }
        public string AccountNumber { get; set; }
        public string Firstname { get; set; }
        public string  Lastname { get; set; }
        public string Othername { get; set; }
        public string Phone { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string DateRegister { get; set; }
    }
}
