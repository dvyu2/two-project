using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_account
{
    public partial class Form1 : Form
    {
        public string[] AccountTypes = new[] { "Банк Акаунт", "Блокчейн Акаунт" };
        public Form1()
        {
            InitializeComponent();
            //var AccountTypes = new[] { "Банк Акаунт", "Блокчейн Акаунт" };
            comboBox1.DataSource = AccountTypes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentcomboBox1Index = comboBox1.SelectedIndex;
            switch (currentcomboBox1Index)
            {
                case 0:
                    label1.Text = AccountTypes[0];
                    break;
                case 1:
                    label1.Text = AccountTypes[1];
                    break;
            }
            //label1.Text = "Hello";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
