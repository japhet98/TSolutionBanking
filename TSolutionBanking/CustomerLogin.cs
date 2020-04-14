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
    public partial class CustomerLogin : Form
    {
        public List<Customer> customers;
        public Validations validate = new Validations();
        public CustomerLogin()
        {
            var repo = new CustomerController();
            repo.GetCustomerDetails();
           customers = repo.GetCustomerDetails();
            //this.Refresh();
          
    
            InitializeComponent();
        }

       
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var status = false;
            var customer = new Customer();
            customers.ForEach(item =>
            {
                if(item.Username == username && item.Password == password)
                {
                    status = true;

                    customer.Firstname = item.Firstname;
                    customer.Lastname = item.Lastname;
                    customer.AccountNumber = item.AccountNumber;
                    customer.AccountType = item.AccountType;
                    customer.CustomerNo = item.CustomerNo;
                    customer.Balance = item.Balance;
                    customer.Othername = item.Othername;
                    customer.Phone = item.Phone;
                    customer.Username = item.Username;
                    customer.Password = item.Password;
                    

                }
               
                
            });
         
            if (status == true)
            {
                Console.WriteLine("new customer:", customer);
                
              
             
                MessageBox.Show("Login Succesful");
                var dashboard = new CustomerDashboard(customer);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!! Invalid username or password ");
            }


            txtUsername.Text = "";
            txtPassword.Text = "";

          
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
          
        }

      
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new CustomerRegistration();
            register.Show();
            this.Hide();
        }

      
        private void DisablePasswordLogin()

        {
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void EnablePasswordLogin()
        {
            txtPassword.Enabled=true;
            btnLogin.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
