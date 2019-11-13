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
    public partial class fordForm : Form
    {
        public fordForm()
        {
            InitializeComponent();
        }

        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            carBrandForm.Show();
            this.Hide();
        }
        private void fordMustang_Click(object sender, EventArgs e)
        {
            model = "Ford Mustang";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        private void fordExpedition_Click(object sender, EventArgs e)
        {
            model = "Ford Expedition";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        private void fordExplorer_Click(object sender, EventArgs e)
        {
            model = "Ford Explorer";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        public static string model = " ";
        public static int counter = 0;

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }
    }
}
