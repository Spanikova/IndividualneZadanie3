namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.dtGrdAccounts = new System.Windows.Forms.DataGridView();
            this.lblIban = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(391, 458);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(140, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Spravovať účet";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // dtGrdAccounts
            // 
            this.dtGrdAccounts.AllowUserToAddRows = false;
            this.dtGrdAccounts.AllowUserToDeleteRows = false;
            this.dtGrdAccounts.AllowUserToResizeColumns = false;
            this.dtGrdAccounts.AllowUserToResizeRows = false;
            this.dtGrdAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdAccounts.Location = new System.Drawing.Point(25, 75);
            this.dtGrdAccounts.Name = "dtGrdAccounts";
            this.dtGrdAccounts.RowHeadersVisible = false;
            this.dtGrdAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdAccounts.Size = new System.Drawing.Size(869, 365);
            this.dtGrdAccounts.TabIndex = 12;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(43, 33);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(35, 13);
            this.lblIban.TabIndex = 13;
            this.lblIban.Text = "IBAN:";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(84, 30);
            this.txtIban.MaxLength = 24;
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(168, 20);
            this.txtIban.TabIndex = 14;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(291, 33);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Priezvisko:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(355, 30);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 20);
            this.txtSurname.TabIndex = 16;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(531, 30);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 524);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.dtGrdAccounts);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prehľad účtov";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.DataGridView dtGrdAccounts;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnFilter;
    }
}