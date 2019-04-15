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
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(14, 32);
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
            this.txtPin.Location = new System.Drawing.Point(14, 79);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(61, 20);
            this.txtPin.TabIndex = 2;
            // 
            // lblInsertPin
            // 
            this.lblInsertPin.AutoSize = true;
            this.lblInsertPin.Location = new System.Drawing.Point(11, 63);
            this.lblInsertPin.Name = "lblInsertPin";
            this.lblInsertPin.Size = new System.Drawing.Size(64, 13);
            this.lblInsertPin.TabIndex = 3;
            this.lblInsertPin.Text = "Zadajte PIN";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnAccept);
            this.pnlLogin.Controls.Add(this.lblInsertCardNum);
            this.pnlLogin.Controls.Add(this.txtPin);
            this.pnlLogin.Controls.Add(this.lblInsertPin);
            this.pnlLogin.Controls.Add(this.txtCardNumber);
            this.pnlLogin.Location = new System.Drawing.Point(81, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(183, 115);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Lime;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Location = new System.Drawing.Point(95, 70);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(76, 36);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Potvrdiť";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BANKOMAT";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblInsertCardNum;
        private Controls.NumericTextBox txtPin;
        private System.Windows.Forms.Label lblInsertPin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnAccept;
    }
}

