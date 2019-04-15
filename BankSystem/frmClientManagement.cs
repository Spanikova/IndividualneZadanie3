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
    public partial class frmClientManagement : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();
        private BankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private CardRepository _cardRepository = new CardRepository();
        private int _clientId = 0;

        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(_clientId))
            {
                DialogResult dialogResult = newForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    frmClientManagement_Load(sender, e);
                }
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete naozaj zatvoriť účet?", "Zatvorenie účtu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bankAccountRepository.CloseAccount(_clientRepository.Client.BankAccount.AccountID);
                DialogResult = DialogResult.OK;
            }
        }

        private void frmClientManagement_Load(object sender, EventArgs e)
        {
            _clientRepository.FindClientById(_clientId);
            lblClientName.Text = $"{_clientRepository.Client.Title } {_clientRepository.Client.Name} {_clientRepository.Client.Surname}".Trim();
            lblClientBirthNumber.Text = $"{_clientRepository.Client.BirthNumber.Substring(0, 6)}/{_clientRepository.Client.BirthNumber.Substring(6, 4)}";
            lblClientIdCard.Text = $"{_clientRepository.Client.IdCardNumber}";
            lblClientStreet.Text = $"{_clientRepository.Client.Street}";
            lblClientCity.Text = $"{_clientRepository.Client.City}";
            lblClientPhoneNumber.Text = $"{_clientRepository.Client.PhoneNumber}";
            lblAccIban.Text = $"{_clientRepository.Client.BankAccount.Iban}";
            lblAccName.Text = $"{_clientRepository.Client.BankAccount.AccountName}";
            lblAccBalance.Text = $"{_clientRepository.Client.BankAccount.AccountBalance} €";
            lblAccLimit.Text = $"{_clientRepository.Client.BankAccount.AuthOverdraftLimit} €";
            lblAccOpenDate.Text = $"{_clientRepository.Client.BankAccount.OpeningDate.ToShortDateString()}";
            dtGrdCards.DataSource = _cardRepository.GetCardsByAccId(_clientRepository.Client.BankAccount.AccountID);
            dtGrdCards.DataMember = "Cards";
            dtGrdCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdCards.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            bool cardInserted = _cardRepository.InsertNewCard(_clientRepository.Client.BankAccount.AccountID);
            dtGrdCards.DataSource = _cardRepository.GetCardsByAccId(_clientRepository.Client.BankAccount.AccountID);
            dtGrdCards.DataMember = "Cards";
            dtGrdCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdCards.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnUnblockCard_Click(object sender, EventArgs e)
        {
            string cardNumber = dtGrdCards.SelectedCells[0].Value.ToString();
            _cardRepository.UnblockCard(cardNumber);
            dtGrdCards.DataSource = _cardRepository.GetCardsByAccId(_clientRepository.Client.BankAccount.AccountID);
            dtGrdCards.DataMember = "Cards";
            dtGrdCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdCards.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}



