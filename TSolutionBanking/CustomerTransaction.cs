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
using TSolutionBanking.ValidationsInput;

namespace TSolutionBanking
{
    public partial class CustomerTransaction : Form
    {
      
        public CustomerTransaction()
        {
            InitializeComponent();
        }


        public string transactiontype { get; private set; }
        public List<Transaction> transaction { get; private set; }
        private Customer customerDetail { get; set; }
      
        public CustomerTransaction(Customer customer,string name)
        {
            InitializeComponent();
            customerDetail = customer;
            lblBalance.Text = customerDetail.Balance.ToString();
            lblCustomerNo.Text = customerDetail.CustomerNo;
            txtFirstname.Text = customerDetail.Firstname;
            txtLastname.Text = customerDetail.Lastname;
            lblDate.Text = System.DateTime.Now.ToShortDateString();

             transactiontype= name ;

            if (transactiontype == "withdraw")
            {
                DisableAccounTextBox(customerDetail);
                lblDeposit.Text = "Withdraw";
            }
            else if(transactiontype == "transfer")
            {
                lblDeposit.Text = "Transfer";
            }
            else
            {
                DisableAccounTextBox(customerDetail);
            }


            
        }

        public void DisableAccounTextBox(Customer customer)
        {
            txtAccountnumber.Enabled = false;
            txtAccountnumber.Text = customer.AccountNumber;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (transactiontype == "deposit")
            {
                Transaction(transactiontype);

            }
            else if(transactiontype == "withdraw")
            {
                Transaction(transactiontype);
            }
            else if(transactiontype == "transfer")
            {
                Transaction(transactiontype);
            }

            

        }

        private async void Transaction(string transtype)
        {

           
            var validate = new Validations();

            if (validate.ValidateDouble(txtAmount.Text) == false)
            {
                txtAmount.Focus();
                errorProvider1.SetError(txtAmount, "Invalid Amount");
                MessageBox.Show("Invalid Amount");
            }

            else
            {
                var tempTrans = new Transaction();
                var status = false;
                tempTrans.Amount = Convert.ToDecimal(txtAmount.Text);
                tempTrans.CustomerNo = lblCustomerNo.Text;
                tempTrans.TransType = transactiontype;
                tempTrans.SenderName = txtFirstname.Text + " " + txtLastname.Text;
                tempTrans.TransDate = Convert.ToDateTime(lblDate.Text);


                if (transtype != "transfer")
            {
                tempTrans.ReceipientAccNo = customerDetail.AccountNumber;
                if (transtype == "deposit")
                {
                    lblBalance.Text = (Convert.ToDecimal(lblBalance.Text) + Convert.ToDecimal(txtAmount.Text)).ToString();

                }
                else
                {
                    lblBalance.Text = (Convert.ToDecimal(lblBalance.Text) - Convert.ToDecimal(txtAmount.Text)).ToString();

                }
                customerDetail.Balance = Convert.ToDecimal(lblBalance.Text);

            }
            else
            {



                tempTrans.ReceipientAccNo = txtAccountnumber.Text;
                var Receiver = new Customer();
                var repo = new CustomerController();
                var NewCustomer = repo.GetCustomerDetails();


                NewCustomer.ForEach(item =>
                 {
                     if (tempTrans.ReceipientAccNo == item.AccountNumber)
                     {

                         Receiver = item;
                         status = true;

                     }



                 });

                if (status == false)
                {
                    MessageBox.Show("The Account Number does not Exist");
                }
                else
                {
                    lblBalance.Text = (Convert.ToDecimal(lblBalance.Text) - Convert.ToDecimal(txtAmount.Text)).ToString();
                    Receiver.Balance += Convert.ToDecimal(txtAmount.Text);
                    customerDetail.Balance = Convert.ToDecimal(lblBalance.Text);
                    var newCustomer = new CustomerController();

                    newCustomer.EditCustomerDetail(await SubmitChanges(Receiver));

                }

            }

            if ((transtype == "transfer" && status == true) || (transtype != "transfer"))
            {
                var updateCustomer = new CustomerController();
                updateCustomer.EditCustomerDetail(await SubmitChanges(customerDetail));


                var Repo = new TransactionController();
                Repo.AddTransaction(tempTrans);
                if (transtype == "deposit")
                {
                    MessageBox.Show("You have Deposited : " + tempTrans.Amount + " t0 " + tempTrans.ReceipientAccNo);

                }
                else if (transtype == "withdraw")
                {
                    MessageBox.Show("You have Withdrawn : " + tempTrans.Amount + " from " + tempTrans.SenderName);
                }
                else if (transtype == "transfer")
                {
                    MessageBox.Show("You have Transferd : " + tempTrans.Amount + " t0 " + tempTrans.ReceipientAccNo);
                }
                updateCustomer.GetCustomerDetails();
                this.Close();
            }


        }
        }

        public async Task<Customer> SubmitChanges(Customer customer)
        {
            return await Task.Run(() =>
            {
                    new CustomerController().EditCustomerDetail(customer);
                return customer;
            });
            
        }

        private void lblDeposit_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
