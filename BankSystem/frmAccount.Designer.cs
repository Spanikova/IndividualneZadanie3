namespace BankSystem
{
    partial class frmAccount
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
            this.lblIban = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.pnlAccountData = new System.Windows.Forms.Panel();
            this.cmbLimit = new System.Windows.Forms.ComboBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.lblAccOpenDate = new System.Windows.Forms.Label();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.lblAccIban = new System.Windows.Forms.Label();
            this.pnlCllientData = new System.Windows.Forms.Panel();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtBirthNumber2 = new Controls.NumericTextBox();
            this.txtPhoneNum = new Controls.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.txtBirthNumber1 = new Controls.NumericTextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblBirthNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.pnlAccountData.SuspendLayout();
            this.pnlCllientData.SuspendLayout();
            this.SuspendLayout();
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
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Location = new System.Drawing.Point(22, 41);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(65, 13);
            this.lblAName.TabIndex = 2;
            this.lblAName.Text = "Názov účtu:";
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
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(22, 95);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(114, 13);
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "Povolené prečerpanie:";
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
            // pnlAccountData
            // 
            this.pnlAccountData.BackColor = System.Drawing.Color.Silver;
            this.pnlAccountData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAccountData.Controls.Add(this.cmbLimit);
            this.pnlAccountData.Controls.Add(this.txtAccName);
            this.pnlAccountData.Controls.Add(this.lblAccOpenDate);
            this.pnlAccountData.Controls.Add(this.lblOpenDate);
            this.pnlAccountData.Controls.Add(this.lblLimit);
            this.pnlAccountData.Controls.Add(this.lblAccBalance);
            this.pnlAccountData.Controls.Add(this.lblBalance);
            this.pnlAccountData.Controls.Add(this.lblAName);
            this.pnlAccountData.Controls.Add(this.lblAccIban);
            this.pnlAccountData.Controls.Add(this.lblIban);
            this.pnlAccountData.Location = new System.Drawing.Point(12, 29);
            this.pnlAccountData.Name = "pnlAccountData";
            this.pnlAccountData.Size = new System.Drawing.Size(335, 183);
            this.pnlAccountData.TabIndex = 20;
            // 
            // cmbLimit
            // 
            this.cmbLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimit.FormattingEnabled = true;
            this.cmbLimit.Items.AddRange(new object[] {
            "0,00 €",
            "50,00 €",
            "100,00 €",
            "150,00 €",
            "200,00 €",
            "250,00 €",
            "300,00 €",
            "350,00 €",
            "400,00 €",
            "450,00 €",
            "500,00 €"});
            this.cmbLimit.Location = new System.Drawing.Point(153, 92);
            this.cmbLimit.Name = "cmbLimit";
            this.cmbLimit.Size = new System.Drawing.Size(82, 21);
            this.cmbLimit.TabIndex = 11;
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(153, 38);
            this.txtAccName.MaxLength = 41;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(160, 20);
            this.txtAccName.TabIndex = 10;
            // 
            // lblAccOpenDate
            // 
            this.lblAccOpenDate.AutoSize = true;
            this.lblAccOpenDate.Location = new System.Drawing.Point(150, 121);
            this.lblAccOpenDate.Name = "lblAccOpenDate";
            this.lblAccOpenDate.Size = new System.Drawing.Size(49, 13);
            this.lblAccOpenDate.TabIndex = 9;
            this.lblAccOpenDate.Text = "1.1.2000";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Location = new System.Drawing.Point(150, 69);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(37, 13);
            this.lblAccBalance.TabIndex = 5;
            this.lblAccBalance.Text = "0,00 €";
            // 
            // lblAccIban
            // 
            this.lblAccIban.AutoSize = true;
            this.lblAccIban.Location = new System.Drawing.Point(150, 15);
            this.lblAccIban.Name = "lblAccIban";
            this.lblAccIban.Size = new System.Drawing.Size(0, 13);
            this.lblAccIban.TabIndex = 1;
            // 
            // pnlCllientData
            // 
            this.pnlCllientData.BackColor = System.Drawing.Color.Silver;
            this.pnlCllientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCllientData.Controls.Add(this.lblSlash);
            this.pnlCllientData.Controls.Add(this.txtBirthNumber2);
            this.pnlCllientData.Controls.Add(this.txtPhoneNum);
            this.pnlCllientData.Controls.Add(this.label2);
            this.pnlCllientData.Controls.Add(this.lblStreet);
            this.pnlCllientData.Controls.Add(this.txtCity);
            this.pnlCllientData.Controls.Add(this.txtStreet);
            this.pnlCllientData.Controls.Add(this.txtTitle);
            this.pnlCllientData.Controls.Add(this.lblTitle);
            this.pnlCllientData.Controls.Add(this.txtSurname);
            this.pnlCllientData.Controls.Add(this.lblSurname);
            this.pnlCllientData.Controls.Add(this.txtIdCard);
            this.pnlCllientData.Controls.Add(this.txtBirthNumber1);
            this.pnlCllientData.Controls.Add(this.txtClientName);
            this.pnlCllientData.Controls.Add(this.lblPhoneNum);
            this.pnlCllientData.Controls.Add(this.lblIdCard);
            this.pnlCllientData.Controls.Add(this.lblBirthNumber);
            this.pnlCllientData.Controls.Add(this.lblName);
            this.pnlCllientData.Location = new System.Drawing.Point(368, 29);
            this.pnlCllientData.Name = "pnlCllientData";
            this.pnlCllientData.Size = new System.Drawing.Size(305, 269);
            this.pnlCllientData.TabIndex = 21;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(209, 110);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 13);
            this.lblSlash.TabIndex = 24;
            this.lblSlash.Text = "/";
            // 
            // txtBirthNumber2
            // 
            this.txtBirthNumber2.AllowDecimals = false;
            this.txtBirthNumber2.AllowNegative = false;
            this.txtBirthNumber2.Location = new System.Drawing.Point(222, 107);
            this.txtBirthNumber2.MaxLength = 4;
            this.txtBirthNumber2.Name = "txtBirthNumber2";
            this.txtBirthNumber2.Size = new System.Drawing.Size(55, 20);
            this.txtBirthNumber2.TabIndex = 23;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(107, 232);
            this.txtPhoneNum.MaxLength = 15;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(170, 20);
            this.txtPhoneNum.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mesto:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(17, 172);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(84, 13);
            this.lblStreet.TabIndex = 20;
            this.lblStreet.Text = "Ulica a č. domu:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(107, 202);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 20);
            this.txtCity.TabIndex = 19;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(107, 169);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(170, 20);
            this.txtStreet.TabIndex = 18;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 74);
            this.txtTitle.MaxLength = 15;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(170, 20);
            this.txtTitle.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(17, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Titul:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(107, 42);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 20);
            this.txtSurname.TabIndex = 15;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 45);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 13);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Priezvisko:";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(107, 137);
            this.txtIdCard.MaxLength = 8;
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(170, 20);
            this.txtIdCard.TabIndex = 13;
            // 
            // txtBirthNumber1
            // 
            this.txtBirthNumber1.AllowDecimals = false;
            this.txtBirthNumber1.AllowNegative = false;
            this.txtBirthNumber1.Location = new System.Drawing.Point(107, 107);
            this.txtBirthNumber1.MaxLength = 6;
            this.txtBirthNumber1.Name = "txtBirthNumber1";
            this.txtBirthNumber1.Size = new System.Drawing.Size(96, 20);
            this.txtBirthNumber1.TabIndex = 12;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(107, 12);
            this.txtClientName.MaxLength = 20;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(170, 20);
            this.txtClientName.TabIndex = 11;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(17, 235);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(57, 13);
            this.lblPhoneNum.TabIndex = 8;
            this.lblPhoneNum.Text = "Tel. číslo: ";
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Location = new System.Drawing.Point(17, 140);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(52, 13);
            this.lblIdCard.TabIndex = 6;
            this.lblIdCard.Text = "Číslo OP:";
            // 
            // lblBirthNumber
            // 
            this.lblBirthNumber.AutoSize = true;
            this.lblBirthNumber.Location = new System.Drawing.Point(17, 110);
            this.lblBirthNumber.Name = "lblBirthNumber";
            this.lblBirthNumber.Size = new System.Drawing.Size(68, 13);
            this.lblBirthNumber.TabIndex = 4;
            this.lblBirthNumber.Text = "Rodné číslo:";
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
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(23, 13);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(136, 13);
            this.lblAccount.TabIndex = 22;
            this.lblAccount.Text = "Základné informácie o účte";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(387, 13);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(154, 13);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "Základné informácie o klientovi";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(75, 275);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 24;
            this.btnAccept.Text = "Potvrdiť";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(215, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfoText.Location = new System.Drawing.Point(48, 225);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(76, 20);
            this.lblInfoText.TabIndex = 26;
            this.lblInfoText.Text = "Info text";
            this.lblInfoText.Visible = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(695, 313);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pnlCllientData);
            this.Controls.Add(this.pnlAccountData);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Údaje o klientovi a účte";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.pnlAccountData.ResumeLayout(false);
            this.pnlAccountData.PerformLayout();
            this.pnlCllientData.ResumeLayout(false);
            this.pnlCllientData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Panel pnlAccountData;
        private System.Windows.Forms.Label lblAccOpenDate;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label lblAccIban;
        private System.Windows.Forms.ComboBox cmbLimit;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Panel pnlCllientData;
        private Controls.NumericTextBox txtBirthNumber1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblBirthNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private Controls.NumericTextBox txtPhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Label lblSlash;
        private Controls.NumericTextBox txtBirthNumber2;
    }
}