﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karbro
{
    public partial class recieptForm : Form
    {
        public recieptForm()
        {
            InitializeComponent();
        }

        private void recieptForm_Load(object sender, EventArgs e)
        {
            price.Text = CashOutForm.price;
            name.Text = CashOutForm.name;
            carmodel.Text = CashOutForm.carname;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }
    }
}
