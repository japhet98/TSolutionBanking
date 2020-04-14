namespace TSolutionBanking
{
    partial class CustomerTransactionStatement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransactionStatement));
            this.dgvTransStatement = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printTransactions = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipientAccNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransStatement
            // 
            this.dgvTransStatement.AllowUserToDeleteRows = false;
            this.dgvTransStatement.AutoGenerateColumns = false;
            this.dgvTransStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransStatement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snDataGridViewTextBoxColumn,
            this.transactionIdDataGridViewTextBoxColumn,
            this.customerNoDataGridViewTextBoxColumn,
            this.transTypeDataGridViewTextBoxColumn,
            this.senderNameDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.receipientAccNoDataGridViewTextBoxColumn});
            this.dgvTransStatement.DataSource = this.transactionBindingSource;
            this.dgvTransStatement.Location = new System.Drawing.Point(0, 0);
            this.dgvTransStatement.MultiSelect = false;
            this.dgvTransStatement.Name = "dgvTransStatement";
            this.dgvTransStatement.ReadOnly = true;
            this.dgvTransStatement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTransStatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTransStatement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransStatement.Size = new System.Drawing.Size(832, 441);
            this.dgvTransStatement.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(666, 447);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 57);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(494, 447);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 57);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printTransactions
            // 
            this.printTransactions.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTransactions_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printTransactions;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.snDataGridViewTextBoxColumn.DataPropertyName = "sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            this.snDataGridViewTextBoxColumn.Width = 21;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNoDataGridViewTextBoxColumn
            // 
            this.customerNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerNo";
            this.customerNoDataGridViewTextBoxColumn.HeaderText = "CustomerNo";
            this.customerNoDataGridViewTextBoxColumn.Name = "customerNoDataGridViewTextBoxColumn";
            this.customerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transTypeDataGridViewTextBoxColumn
            // 
            this.transTypeDataGridViewTextBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewTextBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
            this.transTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderNameDataGridViewTextBoxColumn
            // 
            this.senderNameDataGridViewTextBoxColumn.DataPropertyName = "SenderName";
            this.senderNameDataGridViewTextBoxColumn.HeaderText = "SenderName";
            this.senderNameDataGridViewTextBoxColumn.Name = "senderNameDataGridViewTextBoxColumn";
            this.senderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receipientAccNoDataGridViewTextBoxColumn
            // 
            this.receipientAccNoDataGridViewTextBoxColumn.DataPropertyName = "ReceipientAccNo";
            this.receipientAccNoDataGridViewTextBoxColumn.HeaderText = "ReceipientAccNo";
            this.receipientAccNoDataGridViewTextBoxColumn.Name = "receipientAccNoDataGridViewTextBoxColumn";
            this.receipientAccNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(TSolutionBanking.Transaction);
            // 
            // CustomerTransactionStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(831, 501);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvTransStatement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CustomerTransactionStatement";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Transaction Statement";
            this.Load += new System.EventHandler(this.CustomerTransactionStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransStatement;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printTransactions;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipientAccNoDataGridViewTextBoxColumn;
    }
}