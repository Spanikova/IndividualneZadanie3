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
    /// <summary>
    /// Form for viewing list of accounts.
    /// </summary>
    public partial class frmAccounts : Form
    {
        private BankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private string iban = "";
        private string surname = "";

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            int selectedId = (int) dtGrdAccounts.SelectedCells[6].Value;
            using (frmClientManagement newForm = new frmClientManagement(selectedId))
            {
                newForm.ShowDialog();
            }
            DialogResult = DialogResult.OK;
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            string iban = txtIban.Text;
            string surname = txtSurname.Text;
            FillDataGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            iban = txtIban.Text;
            surname = txtSurname.Text;
            FillDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dtGrdAccounts.DataSource = _bankAccountRepository.GetAllAccounts(iban, surname);
            dtGrdAccounts.DataMember = "BankAccounts";
            dtGrdAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdAccounts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
