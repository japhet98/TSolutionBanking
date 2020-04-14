using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSolutionBanking
{
    public partial class CustomerTransactionStatement : Form
    {
        public CustomerTransactionStatement()
        {
            InitializeComponent();

        }
         public CustomerTransactionStatement(List<Transaction> trans)
        {
            InitializeComponent();

            dgvTransStatement.DataSource = trans;
            
        }

        private void CustomerTransactionStatement_Load(object sender, EventArgs e)
        {

        }
     
        private void printTransactions_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(beep, 0, 0);
        }
        Bitmap beep;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            beep = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics ng = Graphics.FromImage(beep);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
