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
        private string _prevCard = "";
        private int _counter = 2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string cardNum = txtCardNumber.Text;
            string pin = txtPin.Text;

            if (_cardRepository.CheckLogin(cardNum, pin))
            {
                pnlLogin.Visible = false;
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
    }
}
