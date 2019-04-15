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

namespace TransformerBank
{
    public partial class frmMain : Form
    {
        private CardRepository _cardRepository = new CardRepository();
        private BankAccountRepository _accountRepository = new BankAccountRepository();
        private TransactionRepository _transactionRepository = new TransactionRepository();
        private string _prevCard = "";
        private int _counter = 2;
        private string cardNum = "";
        private int accId = 0;
        private decimal sum = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            cardNum = txtCardNumber.Text;
            string pin = txtPin.Text;
            if (_cardRepository.CheckLogin(cardNum, pin))
            {
                accId = _cardRepository.getAccId(cardNum);
                if (_accountRepository.CheckIfIdExists(accId))
                {
                    pnlLogin.Visible = false;
                    pnlATMFunctions.Visible = true;
                }
                else
                {
                    lblInfoText.Text = $"Neexistujúci účet";
                }
            }
            else
            {
                _counter--;
                if (!cardNum.Equals(_prevCard))
                {
                    _counter = 2;
                }
                lblInfoText.Text = $"Nesprávne údaje\nZostávajúce pokusy: {_counter}";
                lblInfoText.Visible = true;
                _prevCard = cardNum;
            }
            if (_counter <= 0)
            {
                lblInfoText.Text = $"Príliš veľa pokusov\nKarta je zablokovaná";
                _cardRepository.BlockCard(cardNum);
            }
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            lblBalance.Visible = true;
            lblBalance.Text = $"Stav účtu: { _accountRepository.ShowBalance(accId).ToString()} €";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtWithdrawSum.Text.Length > 0)
            {
                sum = decimal.Parse(txtWithdrawSum.Text);
            }
            bool hasMoney = _accountRepository.CheckIfEnoughMoney(accId, sum);
            if (!hasMoney)
            {
                lblInfoText2.Text = "Nedostatok peňazí na účte";
                lblInfoText2.Visible = true;
            }
            else
            {
                _transactionRepository.Transaction.Amount = sum;
                _transactionRepository.Transaction.SenderID = accId;
                _transactionRepository.Transaction.RecipientID = -99;
                _transactionRepository.Transaction.Time = DateTime.Now;
                _transactionRepository.Transaction.VS = "";
                _transactionRepository.Transaction.KS = "";
                _transactionRepository.Transaction.SS = "";
                _transactionRepository.Transaction.TransMessage = "Výber z bankomatu";
                if (_transactionRepository.InsertTransaction(_transactionRepository.Transaction) > 0)
                {
                    _accountRepository.SubstractMoney(accId, _transactionRepository.Transaction.Amount);
                    pnlATMFunctions.Visible = false;
                    pnlLogin.Visible = true;
                    txtCardNumber.Text = "";
                    txtPin.Text = "";
                    pnlNiceDay.Visible = true;
                    lblNiceDay.Text = "Ďakujeme za transakciu \na prajeme pekný deň.";
                }
            }
        }

    }
}

