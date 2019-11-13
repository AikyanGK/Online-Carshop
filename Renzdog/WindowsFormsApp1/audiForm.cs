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
    public partial class audiForm : Form
    {
        public audiForm()
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

        private void audiA4PicBox_Click(object sender, EventArgs e)
        {
            model = "Audi A4";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void audiRS5PicBox_Click(object sender, EventArgs e)
        {
            model = "Audi RS5";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void audiRS6PicBox_Click(object sender, EventArgs e)
        {
            model = "Audi RS6";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        public static string model = " ";
        public static int counter = 0;
    }
}
