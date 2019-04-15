using Card.Repositories;
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
        private string _prevCard = "";
        private int _counter = 2;
        private string cardNum = "";

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
                pnlLogin.Visible = false;
                pnlATMFunctions.Visible = true;
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
            int accId = _cardRepository.getAccId(cardNum);
            lblBalance.Visible = true;
            lblBalance.Text = $"Stav účtu: { _accountRepository.ShowBalance(accId).ToString()} €";
        }
    }
}
