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
    public partial class frmAccounts : Form
    {
        private BankAccountRepository _bankAccountRepository = new BankAccountRepository();

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
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            dtGrdAccounts.DataSource = _bankAccountRepository.GetAllAccounts();
            dtGrdAccounts.DataMember = "BankAccounts";
            dtGrdAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdAccounts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
