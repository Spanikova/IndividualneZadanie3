namespace BankSystem
{
    partial class frmMain
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
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.txtFindClient = new System.Windows.Forms.TextBox();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlManReview = new System.Windows.Forms.Panel();
            this.pnlTopAccs = new System.Windows.Forms.Panel();
            this.lblTopAccs = new System.Windows.Forms.Label();
            this.dtGrdTopAccs = new System.Windows.Forms.DataGridView();
            this.pnlNumOfAccounts = new System.Windows.Forms.Panel();
            this.lblNumOfAccounts = new System.Windows.Forms.Label();
            this.lblNumAccs = new System.Windows.Forms.Label();
            this.pnlSumMoney = new System.Windows.Forms.Panel();
            this.lblBankMoney = new System.Windows.Forms.Label();
            this.lblMoneySum = new System.Windows.Forms.Label();
            this.pnlCities = new System.Windows.Forms.Panel();
            this.lblTopCities = new System.Windows.Forms.Label();
            this.dtGrdTopCities = new System.Windows.Forms.DataGridView();
            this.pnlAccsMonth = new System.Windows.Forms.Panel();
            this.lblAccsPerMonth = new System.Windows.Forms.Label();
            this.dtGrdAccPerMonth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlManReview.SuspendLayout();
            this.pnlTopAccs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTopAccs)).BeginInit();
            this.pnlNumOfAccounts.SuspendLayout();
            this.pnlSumMoney.SuspendLayout();
            this.pnlCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTopCities)).BeginInit();
            this.pnlAccsMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAccPerMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(585, 160);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 29);
            this.cmdFindClient.TabIndex = 2;
            this.cmdFindClient.Text = "Hľadať klienta";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(585, 289);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "Nový účet";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(585, 336);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(112, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "Prehľad účtov";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(585, 385);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "Prehľad transakcií";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // txtFindClient
            // 
            this.txtFindClient.Location = new System.Drawing.Point(527, 122);
            this.txtFindClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindClient.Name = "txtFindClient";
            this.txtFindClient.Size = new System.Drawing.Size(235, 20);
            this.txtFindClient.TabIndex = 10;
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfoText.Location = new System.Drawing.Point(523, 199);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(76, 20);
            this.lblInfoText.TabIndex = 11;
            this.lblInfoText.Text = "Info text";
            this.lblInfoText.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankSystem.Properties.Resources.bank_islam;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(551, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 59);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pnlManReview
            // 
            this.pnlManReview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlManReview.Controls.Add(this.dtGrdAccPerMonth);
            this.pnlManReview.Controls.Add(this.pnlAccsMonth);
            this.pnlManReview.Controls.Add(this.dtGrdTopCities);
            this.pnlManReview.Controls.Add(this.pnlCities);
            this.pnlManReview.Controls.Add(this.pnlTopAccs);
            this.pnlManReview.Controls.Add(this.dtGrdTopAccs);
            this.pnlManReview.Controls.Add(this.pnlNumOfAccounts);
            this.pnlManReview.Controls.Add(this.pnlSumMoney);
            this.pnlManReview.Location = new System.Drawing.Point(13, 21);
            this.pnlManReview.Name = "pnlManReview";
            this.pnlManReview.Size = new System.Drawing.Size(504, 456);
            this.pnlManReview.TabIndex = 13;
            // 
            // pnlTopAccs
            // 
            this.pnlTopAccs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTopAccs.Controls.Add(this.lblTopAccs);
            this.pnlTopAccs.Location = new System.Drawing.Point(3, 125);
            this.pnlTopAccs.Name = "pnlTopAccs";
            this.pnlTopAccs.Size = new System.Drawing.Size(235, 39);
            this.pnlTopAccs.TabIndex = 5;
            // 
            // lblTopAccs
            // 
            this.lblTopAccs.AutoSize = true;
            this.lblTopAccs.Location = new System.Drawing.Point(14, 14);
            this.lblTopAccs.Name = "lblTopAccs";
            this.lblTopAccs.Size = new System.Drawing.Size(77, 13);
            this.lblTopAccs.TabIndex = 0;
            this.lblTopAccs.Text = "TOP 10 účtov:";
            // 
            // dtGrdTopAccs
            // 
            this.dtGrdTopAccs.AllowUserToAddRows = false;
            this.dtGrdTopAccs.AllowUserToDeleteRows = false;
            this.dtGrdTopAccs.AllowUserToResizeColumns = false;
            this.dtGrdTopAccs.AllowUserToResizeRows = false;
            this.dtGrdTopAccs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdTopAccs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdTopAccs.Location = new System.Drawing.Point(3, 170);
            this.dtGrdTopAccs.Name = "dtGrdTopAccs";
            this.dtGrdTopAccs.RowHeadersVisible = false;
            this.dtGrdTopAccs.Size = new System.Drawing.Size(235, 275);
            this.dtGrdTopAccs.TabIndex = 4;
            // 
            // pnlNumOfAccounts
            // 
            this.pnlNumOfAccounts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNumOfAccounts.Controls.Add(this.lblNumOfAccounts);
            this.pnlNumOfAccounts.Controls.Add(this.lblNumAccs);
            this.pnlNumOfAccounts.Location = new System.Drawing.Point(3, 69);
            this.pnlNumOfAccounts.Name = "pnlNumOfAccounts";
            this.pnlNumOfAccounts.Size = new System.Drawing.Size(235, 39);
            this.pnlNumOfAccounts.TabIndex = 3;
            // 
            // lblNumOfAccounts
            // 
            this.lblNumOfAccounts.AutoSize = true;
            this.lblNumOfAccounts.Location = new System.Drawing.Point(14, 14);
            this.lblNumOfAccounts.Name = "lblNumOfAccounts";
            this.lblNumOfAccounts.Size = new System.Drawing.Size(119, 13);
            this.lblNumOfAccounts.TabIndex = 0;
            this.lblNumOfAccounts.Text = "Počet aktívnych účtov:";
            // 
            // lblNumAccs
            // 
            this.lblNumAccs.AutoSize = true;
            this.lblNumAccs.Location = new System.Drawing.Point(150, 14);
            this.lblNumAccs.Name = "lblNumAccs";
            this.lblNumAccs.Size = new System.Drawing.Size(30, 13);
            this.lblNumAccs.TabIndex = 1;
            this.lblNumAccs.Text = "accs";
            // 
            // pnlSumMoney
            // 
            this.pnlSumMoney.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSumMoney.Controls.Add(this.lblBankMoney);
            this.pnlSumMoney.Controls.Add(this.lblMoneySum);
            this.pnlSumMoney.Location = new System.Drawing.Point(3, 17);
            this.pnlSumMoney.Name = "pnlSumMoney";
            this.pnlSumMoney.Size = new System.Drawing.Size(235, 42);
            this.pnlSumMoney.TabIndex = 2;
            // 
            // lblBankMoney
            // 
            this.lblBankMoney.AutoSize = true;
            this.lblBankMoney.Location = new System.Drawing.Point(14, 14);
            this.lblBankMoney.Name = "lblBankMoney";
            this.lblBankMoney.Size = new System.Drawing.Size(130, 13);
            this.lblBankMoney.TabIndex = 0;
            this.lblBankMoney.Text = "Suma prostriedkov banky:";
            // 
            // lblMoneySum
            // 
            this.lblMoneySum.AutoSize = true;
            this.lblMoneySum.Location = new System.Drawing.Point(150, 14);
            this.lblMoneySum.Name = "lblMoneySum";
            this.lblMoneySum.Size = new System.Drawing.Size(38, 13);
            this.lblMoneySum.TabIndex = 1;
            this.lblMoneySum.Text = "money";
            // 
            // pnlCities
            // 
            this.pnlCities.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCities.Controls.Add(this.lblTopCities);
            this.pnlCities.Location = new System.Drawing.Point(257, 17);
            this.pnlCities.Name = "pnlCities";
            this.pnlCities.Size = new System.Drawing.Size(235, 38);
            this.pnlCities.TabIndex = 6;
            // 
            // lblTopCities
            // 
            this.lblTopCities.AutoSize = true;
            this.lblTopCities.Location = new System.Drawing.Point(14, 14);
            this.lblTopCities.Name = "lblTopCities";
            this.lblTopCities.Size = new System.Drawing.Size(68, 13);
            this.lblTopCities.TabIndex = 0;
            this.lblTopCities.Text = "TOP 5 miest:";
            // 
            // dtGrdTopCities
            // 
            this.dtGrdTopCities.AllowUserToAddRows = false;
            this.dtGrdTopCities.AllowUserToDeleteRows = false;
            this.dtGrdTopCities.AllowUserToResizeColumns = false;
            this.dtGrdTopCities.AllowUserToResizeRows = false;
            this.dtGrdTopCities.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdTopCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdTopCities.Location = new System.Drawing.Point(257, 61);
            this.dtGrdTopCities.Name = "dtGrdTopCities";
            this.dtGrdTopCities.RowHeadersVisible = false;
            this.dtGrdTopCities.Size = new System.Drawing.Size(235, 135);
            this.dtGrdTopCities.TabIndex = 7;
            // 
            // pnlAccsMonth
            // 
            this.pnlAccsMonth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAccsMonth.Controls.Add(this.lblAccsPerMonth);
            this.pnlAccsMonth.Location = new System.Drawing.Point(257, 222);
            this.pnlAccsMonth.Name = "pnlAccsMonth";
            this.pnlAccsMonth.Size = new System.Drawing.Size(235, 29);
            this.pnlAccsMonth.TabIndex = 8;
            // 
            // lblAccsPerMonth
            // 
            this.lblAccsPerMonth.AutoSize = true;
            this.lblAccsPerMonth.Location = new System.Drawing.Point(14, 14);
            this.lblAccsPerMonth.Name = "lblAccsPerMonth";
            this.lblAccsPerMonth.Size = new System.Drawing.Size(160, 13);
            this.lblAccsPerMonth.TabIndex = 0;
            this.lblAccsPerMonth.Text = "Účty za posledných 6 mesiacov:";
            // 
            // dtGrdAccPerMonth
            // 
            this.dtGrdAccPerMonth.AllowUserToAddRows = false;
            this.dtGrdAccPerMonth.AllowUserToDeleteRows = false;
            this.dtGrdAccPerMonth.AllowUserToResizeColumns = false;
            this.dtGrdAccPerMonth.AllowUserToResizeRows = false;
            this.dtGrdAccPerMonth.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdAccPerMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdAccPerMonth.Location = new System.Drawing.Point(257, 257);
            this.dtGrdAccPerMonth.Name = "dtGrdAccPerMonth";
            this.dtGrdAccPerMonth.RowHeadersVisible = false;
            this.dtGrdAccPerMonth.Size = new System.Drawing.Size(235, 188);
            this.dtGrdAccPerMonth.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.pnlManReview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.txtFindClient);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BANK ISLAM - Bankový systém";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlManReview.ResumeLayout(false);
            this.pnlTopAccs.ResumeLayout(false);
            this.pnlTopAccs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTopAccs)).EndInit();
            this.pnlNumOfAccounts.ResumeLayout(false);
            this.pnlNumOfAccounts.PerformLayout();
            this.pnlSumMoney.ResumeLayout(false);
            this.pnlSumMoney.PerformLayout();
            this.pnlCities.ResumeLayout(false);
            this.pnlCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTopCities)).EndInit();
            this.pnlAccsMonth.ResumeLayout(false);
            this.pnlAccsMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAccPerMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.TextBox txtFindClient;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlManReview;
        private System.Windows.Forms.Label lblMoneySum;
        private System.Windows.Forms.Label lblBankMoney;
        private System.Windows.Forms.Panel pnlSumMoney;
        private System.Windows.Forms.Panel pnlNumOfAccounts;
        private System.Windows.Forms.Label lblNumOfAccounts;
        private System.Windows.Forms.Label lblNumAccs;
        private System.Windows.Forms.Panel pnlTopAccs;
        private System.Windows.Forms.Label lblTopAccs;
        private System.Windows.Forms.DataGridView dtGrdTopAccs;
        private System.Windows.Forms.Panel pnlCities;
        private System.Windows.Forms.Label lblTopCities;
        private System.Windows.Forms.DataGridView dtGrdTopCities;
        private System.Windows.Forms.Panel pnlAccsMonth;
        private System.Windows.Forms.Label lblAccsPerMonth;
        private System.Windows.Forms.DataGridView dtGrdAccPerMonth;
    }
}

