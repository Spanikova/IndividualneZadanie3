namespace BankSystem
{
    partial class frmClientManagement
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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.pnlCllientData = new System.Windows.Forms.Panel();
            this.lblClientCity = new System.Windows.Forms.Label();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblClientIdCard = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblClientBirthNumber = new System.Windows.Forms.Label();
            this.lblBirthNumber = new System.Windows.Forms.Label();
            this.lblClientStreet = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlAccountData = new System.Windows.Forms.Panel();
            this.lblAccOpenDate = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblAccLimit = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblAccIban = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnNewCard = new System.Windows.Forms.Button();
            this.dtGrdCards = new System.Windows.Forms.DataGridView();
            this.btnUnblockCard = new System.Windows.Forms.Button();
            this.pnlCllientData.SuspendLayout();
            this.pnlAccountData.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCards)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(22, 26);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Aktualizovať údaje";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Location = new System.Drawing.Point(167, 112);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(112, 23);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "Nová transakcia";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Location = new System.Drawing.Point(22, 69);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Zatvoriť účet";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(22, 112);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "Všetky transakcie";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Location = new System.Drawing.Point(167, 69);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(112, 23);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Výber hotovosti";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(167, 26);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(112, 23);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Vklad hotovosti";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // pnlCllientData
            // 
            this.pnlCllientData.BackColor = System.Drawing.Color.Silver;
            this.pnlCllientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCllientData.Controls.Add(this.lblClientCity);
            this.pnlCllientData.Controls.Add(this.lblClientPhoneNumber);
            this.pnlCllientData.Controls.Add(this.lblPhoneNum);
            this.pnlCllientData.Controls.Add(this.lblClientIdCard);
            this.pnlCllientData.Controls.Add(this.lblIdCard);
            this.pnlCllientData.Controls.Add(this.lblClientBirthNumber);
            this.pnlCllientData.Controls.Add(this.lblBirthNumber);
            this.pnlCllientData.Controls.Add(this.lblClientStreet);
            this.pnlCllientData.Controls.Add(this.lblClientName);
            this.pnlCllientData.Controls.Add(this.lblAddress);
            this.pnlCllientData.Controls.Add(this.lblName);
            this.pnlCllientData.Location = new System.Drawing.Point(383, 40);
            this.pnlCllientData.Name = "pnlCllientData";
            this.pnlCllientData.Size = new System.Drawing.Size(305, 183);
            this.pnlCllientData.TabIndex = 18;
            // 
            // lblClientCity
            // 
            this.lblClientCity.AutoSize = true;
            this.lblClientCity.Location = new System.Drawing.Point(104, 121);
            this.lblClientCity.Name = "lblClientCity";
            this.lblClientCity.Size = new System.Drawing.Size(24, 13);
            this.lblClientCity.TabIndex = 10;
            this.lblClientCity.Text = "City";
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.AutoSize = true;
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(104, 149);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lblClientPhoneNumber.TabIndex = 9;
            this.lblClientPhoneNumber.Text = "Phone number";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(17, 149);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(57, 13);
            this.lblPhoneNum.TabIndex = 8;
            this.lblPhoneNum.Text = "Tel. číslo: ";
            // 
            // lblClientIdCard
            // 
            this.lblClientIdCard.AutoSize = true;
            this.lblClientIdCard.Location = new System.Drawing.Point(104, 69);
            this.lblClientIdCard.Name = "lblClientIdCard";
            this.lblClientIdCard.Size = new System.Drawing.Size(40, 13);
            this.lblClientIdCard.TabIndex = 7;
            this.lblClientIdCard.Text = "Id card";
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Location = new System.Drawing.Point(17, 69);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(52, 13);
            this.lblIdCard.TabIndex = 6;
            this.lblIdCard.Text = "Číslo OP:";
            // 
            // lblClientBirthNumber
            // 
            this.lblClientBirthNumber.AutoSize = true;
            this.lblClientBirthNumber.Location = new System.Drawing.Point(104, 41);
            this.lblClientBirthNumber.Name = "lblClientBirthNumber";
            this.lblClientBirthNumber.Size = new System.Drawing.Size(66, 13);
            this.lblClientBirthNumber.TabIndex = 5;
            this.lblClientBirthNumber.Text = "Birth number";
            // 
            // lblBirthNumber
            // 
            this.lblBirthNumber.AutoSize = true;
            this.lblBirthNumber.Location = new System.Drawing.Point(17, 41);
            this.lblBirthNumber.Name = "lblBirthNumber";
            this.lblBirthNumber.Size = new System.Drawing.Size(68, 13);
            this.lblBirthNumber.TabIndex = 4;
            this.lblBirthNumber.Text = "Rodné číslo:";
            // 
            // lblClientStreet
            // 
            this.lblClientStreet.AutoSize = true;
            this.lblClientStreet.Location = new System.Drawing.Point(104, 95);
            this.lblClientStreet.Name = "lblClientStreet";
            this.lblClientStreet.Size = new System.Drawing.Size(35, 13);
            this.lblClientStreet.TabIndex = 3;
            this.lblClientStreet.Text = "Street";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(104, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(35, 13);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Adresa:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Meno:";
            // 
            // pnlAccountData
            // 
            this.pnlAccountData.BackColor = System.Drawing.Color.Silver;
            this.pnlAccountData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAccountData.Controls.Add(this.lblAccOpenDate);
            this.pnlAccountData.Controls.Add(this.lblOpenDate);
            this.pnlAccountData.Controls.Add(this.lblAccLimit);
            this.pnlAccountData.Controls.Add(this.lblLimit);
            this.pnlAccountData.Controls.Add(this.lblAccBalance);
            this.pnlAccountData.Controls.Add(this.lblBalance);
            this.pnlAccountData.Controls.Add(this.lblAccName);
            this.pnlAccountData.Controls.Add(this.lblAName);
            this.pnlAccountData.Controls.Add(this.lblAccIban);
            this.pnlAccountData.Controls.Add(this.lblIban);
            this.pnlAccountData.Location = new System.Drawing.Point(17, 40);
            this.pnlAccountData.Name = "pnlAccountData";
            this.pnlAccountData.Size = new System.Drawing.Size(335, 183);
            this.pnlAccountData.TabIndex = 19;
            // 
            // lblAccOpenDate
            // 
            this.lblAccOpenDate.AutoSize = true;
            this.lblAccOpenDate.Location = new System.Drawing.Point(150, 121);
            this.lblAccOpenDate.Name = "lblAccOpenDate";
            this.lblAccOpenDate.Size = new System.Drawing.Size(85, 13);
            this.lblAccOpenDate.TabIndex = 9;
            this.lblAccOpenDate.Text = "Dátum založenia";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Location = new System.Drawing.Point(22, 121);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(88, 13);
            this.lblOpenDate.TabIndex = 8;
            this.lblOpenDate.Text = "Dátum založenia:";
            // 
            // lblAccLimit
            // 
            this.lblAccLimit.AutoSize = true;
            this.lblAccLimit.Location = new System.Drawing.Point(150, 95);
            this.lblAccLimit.Name = "lblAccLimit";
            this.lblAccLimit.Size = new System.Drawing.Size(28, 13);
            this.lblAccLimit.TabIndex = 7;
            this.lblAccLimit.Text = "Limit";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(22, 95);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(114, 13);
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "Povolené prečerpanie:";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Location = new System.Drawing.Point(150, 69);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(46, 13);
            this.lblAccBalance.TabIndex = 5;
            this.lblAccBalance.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(22, 69);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Zostatok na účte:";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(150, 41);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(76, 13);
            this.lblAccName.TabIndex = 3;
            this.lblAccName.Text = "Account name";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Location = new System.Drawing.Point(22, 41);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(65, 13);
            this.lblAName.TabIndex = 2;
            this.lblAName.Text = "Názov účtu:";
            // 
            // lblAccIban
            // 
            this.lblAccIban.AutoSize = true;
            this.lblAccIban.Location = new System.Drawing.Point(150, 15);
            this.lblAccIban.Name = "lblAccIban";
            this.lblAccIban.Size = new System.Drawing.Size(32, 13);
            this.lblAccIban.TabIndex = 1;
            this.lblAccIban.Text = "IBAN";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(22, 15);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(38, 13);
            this.lblIban.TabIndex = 0;
            this.lblIban.Text = "IBAN: ";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(390, 24);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(154, 13);
            this.lblClient.TabIndex = 20;
            this.lblClient.Text = "Základné informácie o klientovi";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(28, 24);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(136, 13);
            this.lblAccount.TabIndex = 21;
            this.lblAccount.Text = "Základné informácie o účte";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmdNewTransaction);
            this.pnlControls.Controls.Add(this.cmdUpdate);
            this.pnlControls.Controls.Add(this.cmdCloseAccount);
            this.pnlControls.Controls.Add(this.cmdAllTransactions);
            this.pnlControls.Controls.Add(this.cmdWithdrawal);
            this.pnlControls.Controls.Add(this.cmdDeposit);
            this.pnlControls.Location = new System.Drawing.Point(383, 229);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(305, 169);
            this.pnlControls.TabIndex = 22;
            // 
            // btnNewCard
            // 
            this.btnNewCard.Location = new System.Drawing.Point(31, 375);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Size = new System.Drawing.Size(143, 23);
            this.btnNewCard.TabIndex = 23;
            this.btnNewCard.Text = "Nová karta";
            this.btnNewCard.UseVisualStyleBackColor = true;
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // dtGrdCards
            // 
            this.dtGrdCards.AllowUserToAddRows = false;
            this.dtGrdCards.AllowUserToDeleteRows = false;
            this.dtGrdCards.AllowUserToResizeColumns = false;
            this.dtGrdCards.AllowUserToResizeRows = false;
            this.dtGrdCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCards.Location = new System.Drawing.Point(17, 248);
            this.dtGrdCards.Name = "dtGrdCards";
            this.dtGrdCards.ReadOnly = true;
            this.dtGrdCards.RowHeadersVisible = false;
            this.dtGrdCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdCards.Size = new System.Drawing.Size(335, 116);
            this.dtGrdCards.TabIndex = 24;
            // 
            // btnUnblockCard
            // 
            this.btnUnblockCard.Location = new System.Drawing.Point(192, 375);
            this.btnUnblockCard.Name = "btnUnblockCard";
            this.btnUnblockCard.Size = new System.Drawing.Size(141, 23);
            this.btnUnblockCard.TabIndex = 25;
            this.btnUnblockCard.Text = "Odblokovať kartu";
            this.btnUnblockCard.UseVisualStyleBackColor = true;
            this.btnUnblockCard.Click += new System.EventHandler(this.btnUnblockCard_Click);
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.btnUnblockCard);
            this.Controls.Add(this.dtGrdCards);
            this.Controls.Add(this.btnNewCard);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.pnlAccountData);
            this.Controls.Add(this.pnlCllientData);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail klienta";
            this.Load += new System.EventHandler(this.frmClientManagement_Load);
            this.pnlCllientData.ResumeLayout(false);
            this.pnlCllientData.PerformLayout();
            this.pnlAccountData.ResumeLayout(false);
            this.pnlAccountData.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.Panel pnlCllientData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientStreet;
        private System.Windows.Forms.Label lblClientBirthNumber;
        private System.Windows.Forms.Label lblBirthNumber;
        private System.Windows.Forms.Label lblClientIdCard;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Panel pnlAccountData;
        private System.Windows.Forms.Label lblAccLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label lblAccIban;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblClientCity;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblAccOpenDate;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Button btnNewCard;
        private System.Windows.Forms.DataGridView dtGrdCards;
        private System.Windows.Forms.Button btnUnblockCard;
    }
}