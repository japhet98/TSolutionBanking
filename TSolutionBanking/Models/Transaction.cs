using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSolutionBanking.Models
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public string CustomerNo { get; set; }
        public string  TransType { get; set; }
        public string  SenderName { get; set; }
        public string TransDate { get; set; }
        public decimal Amount { get; set; }
        public string  ReceipientAccNo { get; set; }
    }
}
