﻿using Data.Repositories;
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
    public partial class frmAccount : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();
        private int _clientId = 0;

        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }



        private void frmAccount_Load(object sender, EventArgs e)
        {
            lblAccOpenDate.Text = DateTime.Now.ToShortDateString();
            if (_clientId > 0)
            {
                _clientRepository.FindClientById(_clientId);
                lblAccIban.Text = $"{_clientRepository.Client.BankAccount.IBAN}";
                txtAccName.Text = $"{_clientRepository.Client.BankAccount.AccountName}";
                lblAccBalance.Text = $"{_clientRepository.Client.BankAccount.AccountBalance} €";
                cmbLimit.Text = $"{_clientRepository.Client.BankAccount.AuthOverdraftLimit} €";
                lblAccOpenDate.Text = $"{_clientRepository.Client.BankAccount.OpeningDate.Date.ToShortDateString()}";
                txtClientName.Text = $"{_clientRepository.Client.Name}";
                txtSurname.Text = $"{_clientRepository.Client.Surname}";
                txtTitle.Text = $"{_clientRepository.Client.Title}";
                txtBirthNumber1.Text = $"{_clientRepository.Client.BirthNumber.Substring(0, 6)}";
                txtBirthNumber2.Text = $"{_clientRepository.Client.BirthNumber.Substring(6, 4)}";
                txtIdCard.Text = $"{_clientRepository.Client.IdCardNumber}";
                txtStreet.Text = $"{_clientRepository.Client.Street}";
                txtCity.Text = $"{_clientRepository.Client.City}";
                txtPhoneNum.Text = $"{_clientRepository.Client.PhoneNumber}";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_clientId > 0)
            {
                _clientRepository.Client.Name = txtClientName.Text;
                _clientRepository.Client.Surname = txtSurname.Text;
                _clientRepository.Client.Title = txtTitle.Text;
                _clientRepository.Client.BirthNumber = txtBirthNumber1.Text + txtBirthNumber2.Text;
                _clientRepository.Client.IdCardNumber = txtIdCard.Text;
                _clientRepository.Client.Street = txtStreet.Text;
                _clientRepository.Client.City = txtCity.Text;
                _clientRepository.Client.PhoneNumber = txtPhoneNum.Text;
                _clientRepository.UpdateClient(_clientRepository.Client);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
