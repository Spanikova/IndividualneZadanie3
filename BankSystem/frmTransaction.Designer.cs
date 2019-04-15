namespace BankSystem
{
    partial class frmTransaction
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
            this.pnlSender = new System.Windows.Forms.Panel();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.pnlRecipient = new System.Windows.Forms.Panel();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.pnlTransInfo = new System.Windows.Forms.Panel();
            this.lblVS = new System.Windows.Forms.Label();
            this.llbSS = new System.Windows.Forms.Label();
            this.lblKS = new System.Windows.Forms.Label();
            this.txtVS = new Controls.NumericTextBox();
            this.txtSS = new Controls.NumericTextBox();
            this.numericTextBox1 = new Controls.NumericTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSender.SuspendLayout();
            this.pnlRecipient.SuspendLayout();
            this.pnlTransInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSender
            // 
            this.pnlSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSender.Controls.Add(this.txtSender);
            this.pnlSender.Controls.Add(this.lblSender);
            this.pnlSender.Location = new System.Drawing.Point(10, 7);
            this.pnlSender.Name = "pnlSender";
            this.pnlSender.Size = new System.Drawing.Size(200, 115);
            this.pnlSender.TabIndex = 8;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(14, 15);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(95, 13);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Odosielateľ - IBAN";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(17, 45);
            this.txtSender.MaxLength = 24;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(150, 20);
            this.txtSender.TabIndex = 1;
            // 
            // pnlRecipient
            // 
            this.pnlRecipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecipient.Controls.Add(this.txtRecipient);
            this.pnlRecipient.Controls.Add(this.lblRecipient);
            this.pnlRecipient.Location = new System.Drawing.Point(228, 7);
            this.pnlRecipient.Name = "pnlRecipient";
            this.pnlRecipient.Size = new System.Drawing.Size(200, 115);
            this.pnlRecipient.TabIndex = 9;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(17, 45);
            this.txtRecipient.MaxLength = 24;
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(150, 20);
            this.txtRecipient.TabIndex = 1;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(14, 15);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(86, 13);
            this.lblRecipient.TabIndex = 0;
            this.lblRecipient.Text = "Prijímateľ - IBAN";
            // 
            // pnlTransInfo
            // 
            this.pnlTransInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransInfo.Controls.Add(this.btnCancel);
            this.pnlTransInfo.Controls.Add(this.btnAccept);
            this.pnlTransInfo.Controls.Add(this.txtMessage);
            this.pnlTransInfo.Controls.Add(this.lblMessage);
            this.pnlTransInfo.Controls.Add(this.numericTextBox1);
            this.pnlTransInfo.Controls.Add(this.txtSS);
            this.pnlTransInfo.Controls.Add(this.txtVS);
            this.pnlTransInfo.Controls.Add(this.lblKS);
            this.pnlTransInfo.Controls.Add(this.llbSS);
            this.pnlTransInfo.Controls.Add(this.lblVS);
            this.pnlTransInfo.Location = new System.Drawing.Point(10, 129);
            this.pnlTransInfo.Name = "pnlTransInfo";
            this.pnlTransInfo.Size = new System.Drawing.Size(418, 146);
            this.pnlTransInfo.TabIndex = 10;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(14, 51);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(90, 13);
            this.lblVS.TabIndex = 0;
            this.lblVS.Text = "Variabilný symbol:";
            // 
            // llbSS
            // 
            this.llbSS.AutoSize = true;
            this.llbSS.Location = new System.Drawing.Point(14, 81);
            this.llbSS.Name = "llbSS";
            this.llbSS.Size = new System.Drawing.Size(94, 13);
            this.llbSS.TabIndex = 1;
            this.llbSS.Text = "Špecifický symbol:";
            // 
            // lblKS
            // 
            this.lblKS.AutoSize = true;
            this.lblKS.Location = new System.Drawing.Point(14, 110);
            this.lblKS.Name = "lblKS";
            this.lblKS.Size = new System.Drawing.Size(98, 13);
            this.lblKS.TabIndex = 2;
            this.lblKS.Text = "Konštantný symbol:";
            // 
            // txtVS
            // 
            this.txtVS.AllowDecimals = false;
            this.txtVS.AllowNegative = false;
            this.txtVS.Location = new System.Drawing.Point(119, 48);
            this.txtVS.MaxLength = 10;
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(100, 20);
            this.txtVS.TabIndex = 3;
            // 
            // txtSS
            // 
            this.txtSS.AllowDecimals = false;
            this.txtSS.AllowNegative = false;
            this.txtSS.Location = new System.Drawing.Point(119, 78);
            this.txtSS.MaxLength = 10;
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 20);
            this.txtSS.TabIndex = 4;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowDecimals = false;
            this.numericTextBox1.AllowNegative = false;
            this.numericTextBox1.Location = new System.Drawing.Point(119, 107);
            this.numericTextBox1.MaxLength = 4;
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(14, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(106, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Správa pre príjemcu:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(126, 11);
            this.txtMessage.MaxLength = 20;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(279, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(310, 62);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(95, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Potvrď";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.pnlTransInfo);
            this.Controls.Add(this.pnlRecipient);
            this.Controls.Add(this.pnlSender);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transakcia";
            this.pnlSender.ResumeLayout(false);
            this.pnlSender.PerformLayout();
            this.pnlRecipient.ResumeLayout(false);
            this.pnlRecipient.PerformLayout();
            this.pnlTransInfo.ResumeLayout(false);
            this.pnlTransInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSender;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Panel pnlRecipient;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Panel pnlTransInfo;
        private System.Windows.Forms.Label llbSS;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblKS;
        private Controls.NumericTextBox numericTextBox1;
        private Controls.NumericTextBox txtSS;
        private Controls.NumericTextBox txtVS;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}