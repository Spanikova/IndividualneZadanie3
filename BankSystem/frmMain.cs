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

namespace BankSystem
{
    public partial class frmMain : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();
        private BankAccountRepository _bankAccountRepository = new BankAccountRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            lblInfoText.Visible = false;
            string text = txtFindClient.Text;
            int clientId = _clientRepository.FindClientIdByText(text);
            if (clientId > 0)
            {
                using (frmClientManagement newForm = new frmClientManagement(clientId))
                {
                    newForm.ShowDialog();
                }
            }
            else if (clientId == 0)
            {
                lblInfoText.Text = "Klient nebol nájdený v databáze";
                lblInfoText.Visible = true;
            }
            else if (clientId == -1)
            {
                lblInfoText.Text = MainRepository.NO_DB_CONNECTION;
                lblInfoText.Visible = true;
            }
            else
            {
                lblInfoText.Text = MainRepository.UNKNOWN_ERROR;
                lblInfoText.Visible = true;
            }
            txtFindClient.Text = "";
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {

                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblMoneySum.Text = $"{_bankAccountRepository.SumOnAccounts().ToString()} €";
            lblNumAccs.Text = $"{_bankAccountRepository.CountOfAccounts().ToString()}";
            dtGrdTopAccs.DataSource = _bankAccountRepository.TopAccounts();
            dtGrdTopAccs.DataMember = "BankAccounts";
            dtGrdTopAccs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdTopAccs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
