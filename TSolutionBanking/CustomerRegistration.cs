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
 
    public partial class CustomerRegistration : Form
    {
       
        public Customer  C { get; set; }
        public CustomerRegistration()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            dtpdate.Text = System.DateTime.Now.ToShortDateString();
            dtpdate.Enabled = false;

        }

        public CustomerRegistration(Customer customer)
        {
            C = customer;
            InitializeComponent();
            txtFirstname.Text = customer.Firstname;
            txtLastname.Text = customer.Lastname;
            txtOthername.Text = customer.Othername;
            mtxtPhonenumber.Text = customer.Phone;
            txtUsername.Text = customer.Username;
             txtPassword.Text = customer.Password;
            txtDeposit.Enabled = false;
            cmbAccounttype.Enabled = false;
            txtDeposit.Text = customer.Balance.ToString();
            cmbAccounttype.Text = customer.AccountType;
          
            dtpdate.Enabled = false;
            btnRegister.Enabled = false;

                 

        }
        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
                       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            C = new Customer();
            AddUpdateCustomer(C);

        }

        public void AddUpdateCustomer( Customer C)
        {
            txtPassword.PasswordChar = '*';
            var status = false;
            var validation = new Validations();
            var AddUpdateCustomer = new CustomerController();
            if (validation.TextOnlyValidation(txtFirstname.Text) == false)
            {
                txtFirstname.Focus();
                errorProvider1.SetError(txtFirstname, "Enter Correct name");
                 status = true;
                //   MessageBox.Show("Incorrect User Detail Try Again");
            }
            else if (validation.TextOnlyValidation(txtLastname.Text) == false)
            {

                txtLastname.Focus();
                errorProvider1.SetError(txtLastname, "Enter Correct name");
                status = true;
            }
            /* if (txtOthername.Text == null)
             {

                 txtOthername.Focus();
                 errorProvider1.SetError(txtOthername, "Enter Correct name");
                 status = true;
             }*/
            else if (validation.TextOnlyValidation(txtUsername.Text) == false)
            {

                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Enter Correct username");
                status = true;
            }
            else if (validation.ValidateDouble(txtDeposit.Text) == false)
            {

                txtDeposit.Focus();
                errorProvider1.SetError(txtDeposit, "Enter Correct Money");
                status = true;
            }
            else if (validation.ValidatePassword(txtPassword.Text) == false)
            {

                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Enter Correct Password at least 8 characters");
                status = true;
            }
            else if (mtxtPhonenumber.MaskFull == false)
            {

                mtxtPhonenumber.Focus();
                errorProvider1.SetError(mtxtPhonenumber, "Enter Correct Phone number");
                status = true;
            }
            else if (cmbAccounttype.SelectedIndex ==-1)
            {

                cmbAccounttype.Focus();
                errorProvider1.SetError(cmbAccounttype, "Select an Account Type");
                status = true;
            }

            /*else if  ((validation.TextOnlyValidation(txtFirstname.Text) == false &&
              validation.TextOnlyValidation(txtLastname.Text) == false &&
              validation.TextOnlyValidation(txtUsername.Text) == false &&
              mtxtPhonenumber.MaskFull == false &&
            cmbAccounttype.SelectedIndex ==-1 &&
              validation.ValidateDouble(txtDeposit.Text) == false &&
              validation.ValidatePassword(txtPassword.Text) == false
                  ))
              {
                  MessageBox.Show("Incorrect User Detail Try Again");
                  status = true;
              }*/
                
            else
            {
               
                C.Firstname = txtFirstname.Text;
                C.Lastname = txtLastname.Text;
                C.Othername = txtOthername.Text;
                C.DateRegister = Convert.ToDateTime(dtpdate.Text);
                C.Balance = Convert.ToDecimal(txtDeposit.Text);
                C.AccountType = cmbAccounttype.Text;
                C.Phone = mtxtPhonenumber.Text;
                C.Username = txtUsername.Text;
                C.Password = txtPassword.Text;
            }

            if (C.CustomerNo == null && status == false)
            {

                AddUpdateCustomer.AddCustomerDetail(C);
                MessageBox.Show("Registration Succesful");
                var login = new CustomerLogin();
                this.Close();
                login.Visible = true;
            }
            else if(C.CustomerNo !=null && status == false)
            {
                AddUpdateCustomer.EditCustomerDetail(C);
                MessageBox.Show("Update Succesful");
                var dashboard = new CustomerDashboard(C);
                this.Close();
               dashboard.Visible = true;
            }




         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddUpdateCustomer(C);
        }
    }
}
