namespace TransformerBank
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
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblInsertCardNum = new System.Windows.Forms.Label();
            this.txtPin = new Controls.NumericTextBox();
            this.lblInsertPin = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.pnlATMFunctions = new System.Windows.Forms.Panel();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtWithdrawSum = new Controls.NumericTextBox();
            this.pnlLogin.SuspendLayout();
            this.pnlATMFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(112, 13);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(109, 20);
            this.txtCardNumber.TabIndex = 0;
            // 
            // lblInsertCardNum
            // 
            this.lblInsertCardNum.AutoSize = true;
            this.lblInsertCardNum.Location = new System.Drawing.Point(11, 16);
            this.lblInsertCardNum.Name = "lblInsertCardNum";
            this.lblInsertCardNum.Size = new System.Drawing.Size(95, 13);
            this.lblInsertCardNum.TabIndex = 1;
            this.lblInsertCardNum.Text = "Zadajte číslo karty";
            this.lblInsertCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(112, 41);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(76, 20);
            this.txtPin.TabIndex = 2;
            // 
            // lblInsertPin
            // 
            this.lblInsertPin.AutoSize = true;
            this.lblInsertPin.Location = new System.Drawing.Point(42, 44);
            this.lblInsertPin.Name = "lblInsertPin";
            this.lblInsertPin.Size = new System.Drawing.Size(64, 13);
            this.lblInsertPin.TabIndex = 3;
            this.lblInsertPin.Text = "Zadajte PIN";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lblInfoText);
            this.pnlLogin.Controls.Add(this.btnAccept);
            this.pnlLogin.Controls.Add(this.lblInsertCardNum);
            this.pnlLogin.Controls.Add(this.txtPin);
            this.pnlLogin.Controls.Add(this.txtCardNumber);
            this.pnlLogin.Controls.Add(this.lblInsertPin);
            this.pnlLogin.Location = new System.Drawing.Point(73, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(254, 158);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Lime;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Location = new System.Drawing.Point(87, 67);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(76, 29);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Potvrdiť";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfoText.Location = new System.Drawing.Point(30, 99);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(76, 20);
            this.lblInfoText.TabIndex = 12;
            this.lblInfoText.Text = "Info text";
            this.lblInfoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfoText.Visible = false;
            // 
            // pnlATMFunctions
            // 
            this.pnlATMFunctions.Controls.Add(this.txtWithdrawSum);
            this.pnlATMFunctions.Controls.Add(this.lblWithdraw);
            this.pnlATMFunctions.Controls.Add(this.btnWithdraw);
            this.pnlATMFunctions.Controls.Add(this.lblBalance);
            this.pnlATMFunctions.Controls.Add(this.btnShowBalance);
            this.pnlATMFunctions.Location = new System.Drawing.Point(22, 103);
            this.pnlATMFunctions.Name = "pnlATMFunctions";
            this.pnlATMFunctions.Size = new System.Drawing.Size(350, 156);
            this.pnlATMFunctions.TabIndex = 5;
            this.pnlATMFunctions.Visible = false;
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowBalance.Location = new System.Drawing.Point(26, 15);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(304, 32);
            this.btnShowBalance.TabIndex = 0;
            this.btnShowBalance.Text = "Zobraziť stav účtu";
            this.btnShowBalance.UseVisualStyleBackColor = false;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBalance.Location = new System.Drawing.Point(93, 50);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(88, 18);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Stav účtu: ";
            this.lblBalance.Visible = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWithdraw.Location = new System.Drawing.Point(26, 121);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(304, 32);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Výber hotovosti";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWithdraw.Location = new System.Drawing.Point(82, 91);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(89, 16);
            this.lblWithdraw.TabIndex = 3;
            this.lblWithdraw.Text = "Vybrať sumu: ";
            // 
            // txtWithdrawSum
            // 
            this.txtWithdrawSum.AllowDecimals = false;
            this.txtWithdrawSum.AllowNegative = false;
            this.txtWithdrawSum.Location = new System.Drawing.Point(177, 90);
            this.txtWithdrawSum.MaxLength = 3;
            this.txtWithdrawSum.Name = "txtWithdrawSum";
            this.txtWithdrawSum.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawSum.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pnlATMFunctions);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BANKOMAT";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlATMFunctions.ResumeLayout(false);
            this.pnlATMFunctions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblInsertCardNum;
        private Controls.NumericTextBox txtPin;
        private System.Windows.Forms.Label lblInsertPin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Panel pnlATMFunctions;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnShowBalance;
        private Controls.NumericTextBox txtWithdrawSum;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
    }
}

