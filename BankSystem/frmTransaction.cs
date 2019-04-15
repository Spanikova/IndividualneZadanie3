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
    /// <summary>
    /// Form for transactions.
    /// </summary>
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
            if (_senderID == -99)
            {
                txtSender.Visible = false;
                lblBank.Visible = true;
            }
            if (_recipientID == -99)
            {
                txtRecipient.Visible = false;
                lblBank2.Visible = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //checks if sender id is inserted
            int idSender = 0;
            if (txtSender.Text.Length > 0)                          
            {
                idSender = int.Parse(txtSender.Text);
            }
            //checks if recipient id is inserted
            int idRecipient = 0;                                    
            if (txtRecipient.Text.Length > 0)
            {
                idRecipient = int.Parse(txtRecipient.Text);
            }
            //checks if sum is inserted
            decimal sum = 0;
            if (txtSum.Text.Length > 0)
            {
                sum = decimal.Parse(txtSum.Text);
            }
            bool senderExists = false;
            //checks if sender is bank or exists in database
            if (idSender == -99)
            {
                senderExists = true;
            }
            else
            {
                senderExists = _bankAccountRepository.CheckIfIdExists(idSender);
            }
            bool recipientExists = false;
            //checks if recipient is bank or exists in database
            if (idRecipient == -99)
            {
                recipientExists = true;
            }
            else
            {
                recipientExists = _bankAccountRepository.CheckIfIdExists(idRecipient);
            }
            bool senderHasMoney = false;
            if (!recipientExists)
            {
                lblInfoText.Text = "Prijímateľ neexistuje";
                lblInfoText.Visible = true;
            }
            if (!senderExists)
            {
                lblInfoText.Text = "Odosielateľ neexistuje";
                lblInfoText.Visible = true;
            }
            //checks if sender has enough money or is bank
            else
            {
                if(idSender == -99)
                {
                    senderHasMoney = true;
                }
                else
                {
                    senderHasMoney = _bankAccountRepository.CheckIfEnoughMoney(idSender, sum);
                }
                if (!senderHasMoney)
                {
                    lblInfoText.Text = "Odosielateľ nemá \ndostatok peňazí";
                    lblInfoText.Visible = true;
                }
            }
            //performs insert of transaction into database
            if (senderExists && recipientExists && senderHasMoney)
            {
                _transactionRepository.Transaction.Amount = sum;
                _transactionRepository.Transaction.SenderID = idSender;
                _transactionRepository.Transaction.RecipientID = idRecipient;
                _transactionRepository.Transaction.Time = DateTime.Now;
                _transactionRepository.Transaction.VS = txtVS.Text;
                _transactionRepository.Transaction.KS = txtKS.Text;
                _transactionRepository.Transaction.SS = txtSS.Text;
                _transactionRepository.Transaction.TransMessage = txtMessage.Text;
                if (_transactionRepository.InsertTransaction(_transactionRepository.Transaction) > 0)
                {
                    if(idSender != -99)
                    {
                        //substracts money from sender account
                        _bankAccountRepository.SubstractMoney(idSender, _transactionRepository.Transaction.Amount);
                    }
                    if(idRecipient != -99)
                    {
                        //adds money to recipient account
                        _bankAccountRepository.AddMoney(idRecipient, _transactionRepository.Transaction.Amount);
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }
    }

}

