using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSolutionBanking.Controller;

namespace TSolutionBanking
{
    public partial class CustomerDashboard : Form
    {
        public Customer customerOK { get; private set; }
      
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        public CustomerDashboard(Customer customer)
        {
            customerOK = customer;
            InitializeComponent();

            lblUsername.Text = customer.Firstname.Trim();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var name = "deposit";
            OpenDashboard(name);
        }

        public void OpenDashboard(string name)
        {
            var transaction = new CustomerTransaction(customerOK, name);
            transaction.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new CustomerLogin();
            Close();
           login.Visible = true;
            
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var name = "withdraw";
            OpenDashboard(name);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var name = "transfer";
            OpenDashboard(name);
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
         var update =  new CustomerRegistration(customerOK);

            update.Show();
            this.Hide();
           
        }

        private void btnViewStatement_Click(object sender, EventArgs e)
        {
            var TransStatement = new List<Transaction>();

        var getTransactions = new TransactionController();
            getTransactions.GetTransactions().ForEach(trans =>
            {
                if(trans.CustomerNo == customerOK.CustomerNo)
                {
                    TransStatement.Add(trans);
                }
            });

         var viewStatement =  new CustomerTransactionStatement(TransStatement);
            viewStatement.ShowDialog();
        }
    }
}
