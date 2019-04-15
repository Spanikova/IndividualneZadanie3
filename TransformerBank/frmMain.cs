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
                lblInfoText.Text = "Nesprávne údaje";
                lblInfoText.Visible = true;
            }
        }
    }
}
