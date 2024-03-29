﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace bank_account
{
    public partial class Form1 : Form
    {
        //public Account[] AccountTypes = new Account[] { new BankAccount("",0, "Банк Акаунт Васи",""), new BlockchainAccount("", 0, "Блокчейн Акаунт Пети", "") };
        public List<Account> AccountTypes = new List<Account> { new BankAccount("", 0, "Банк Акаунт Васи", ""), new BlockchainAccount("", 0, "Блокчейн Акаунт Пети", "") };
        public List<string> AddressTypes = new List<string>() { "Номер карты", "Публичный адрес" };
        public Form1()
        {
            InitializeComponent();
            //var AccountTypes = new[] { "Банк Акаунт", "Блокчейн Акаунт" };
            //JObject settings = JObject.
            comboBox1.DataSource = new[] { "Банк Акаунт", "Блокчейн Акаунт" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentcomboBox1Index = comboBox1.SelectedIndex;
            IAccount account = AccountTypes[currentcomboBox1Index];
            label1.Text = account.GetBalance().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentcomboBox1Index = comboBox1.SelectedIndex;
            label5.Text = AddressTypes[currentcomboBox1Index];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentcomboBox1Index = comboBox1.SelectedIndex;
            IAccount account = AccountTypes[currentcomboBox1Index];
            label1.Text = account.GetBalance().ToString();
        }
    }
}
