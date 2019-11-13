using System;
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
    public partial class hondaForm : Form
    {
        public hondaForm()
        {
            InitializeComponent();
        }

        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            this.Hide();
            carBrandForm.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }

        private void hondaCRVPicBox_Click(object sender, EventArgs e)
        {
            model = "Honda CR-V";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void hondaBRVPicBox_Click(object sender, EventArgs e)
        {
            model = "Honda BR-V";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void hondaOdysseyPicBox_Click(object sender, EventArgs e)
        {
            model = "Honda Odyssey";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        public static string model = " ";
        public static int counter = 0;
    }
}
