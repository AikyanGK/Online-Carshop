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
    public partial class ferrariForm : Form
    {
        public ferrariForm()
        {
            InitializeComponent();
        }

        private void FerrariPortofinoPicBox_Click(object sender, EventArgs e)
        {
            model = "Ferrari Portofino";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        private void Ferrari812SuperfastPicBox_Click(object sender, EventArgs e)
        {
            model = "Ferrari 812 Superfast";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            carBrandForm.Show();
            this.Hide();
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
