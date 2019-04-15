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
    public partial class frmTransactions : Form
    {
        private TransactionRepository _transactionRepository = new TransactionRepository();
        private int _id = 0;

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(int clientId)
        {
            InitializeComponent();
            _id = clientId;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            if (_id == 0)
            {
                dtGrdTransactions.DataSource = _transactionRepository.GetAllTransactions();
            }
            else
            {
                dtGrdTransactions.DataSource = _transactionRepository.GetAllTransactionsByAccount(_id);
            }
            dtGrdTransactions.DataMember = "Transactions";
            dtGrdTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGrdTransactions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }
    }
}
