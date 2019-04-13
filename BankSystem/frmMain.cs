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
    public partial class frmMain : Form
    {
        private ClientRepository ClientRepository = new ClientRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            lblClientNotExists.Visible = false;
            string text = txtFindClient.Text;
            int clientId = ClientRepository.FindClientIdByText(text);
            if (clientId > 0)
            {
                using (frmClientManagement newForm = new frmClientManagement(clientId))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                lblClientNotExists.Visible = true;
            }
           
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

        }
    }
}
