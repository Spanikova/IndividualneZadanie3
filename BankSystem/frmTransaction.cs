using Card.Repositories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmTransaction : Form
    {
        private int _senderID = 0;
        private int _recipientID = 0;
        private BankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private TransactionRepository _transactionRepository = new TransactionRepository();

        public frmTransaction()
        {
            InitializeComponent();
        }

        public frmTransaction(int senderID, int recipientID)
        {
            InitializeComponent();
            _senderID = senderID;
            _recipientID = recipientID;
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            lblInfoText.Visible = false;
            if (_senderID != 0)
            {
                txtSender.Text = _senderID.ToString();
                txtSender.Enabled = false;
            }
            if (_recipientID != 0)
            {
                txtRecipient.Text = _recipientID.ToString();
                txtRecipient.Enabled = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int idSender = int.Parse(txtSender.Text);
            int idRecipient = int.Parse(txtRecipient.Text);
            decimal sum = decimal.Parse(txtSum.Text);
            bool senderExists = _bankAccountRepository.CheckIfIdExists(idSender);
            bool recipientExists = _bankAccountRepository.CheckIfIdExists(idRecipient);
            bool senderHasMoney = false;
            if (!senderExists)
            {
                lblInfoText.Text = "Odosielateľ neexistuje";
                lblInfoText.Visible = true;
            }
            else
            {
                senderHasMoney = _bankAccountRepository.CheckIfEnoughMoney(idSender, sum);
                if (!senderHasMoney)
                {
                    lblInfoText.Text = "Odosielateľ nemá dostatok peňazí";
                    lblInfoText.Visible = true;
                }
            }
            if (!recipientExists)
            {
                lblInfoText.Text = "Prijímateľ neexistuje";
                lblInfoText.Visible = true;
            }
            if (senderExists && recipientExists)
            {
                _transactionRepository.Transaction.Amount = sum;
                _transactionRepository.Transaction.SenderID = idSender;
                _transactionRepository.Transaction.RecipientID = idRecipient;
                _transactionRepository.Transaction.Time = DateTime.Now;
                _transactionRepository.Transaction.VS = txtVS.Text;
                _transactionRepository.Transaction.KS = txtKS.Text;
                _transactionRepository.Transaction.SS = txtSS.Text;
                _transactionRepository.Transaction.TransMessage = txtMessage.Text;
                int a = _transactionRepository.InsertTransaction(_transactionRepository.Transaction);
                if (a > 0)
                {
                    _bankAccountRepository.SubstractMoney(idSender, _transactionRepository.Transaction.Amount);
                    _bankAccountRepository.AddMoney(idRecipient, _transactionRepository.Transaction.Amount);
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
