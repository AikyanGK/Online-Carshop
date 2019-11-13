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
    public partial class volvoForm : Form
    {
        public volvoForm()
        {
            InitializeComponent();
        }

        public void XC40picbox_Click(object sender, EventArgs e)
        {
            model = "Volvo XC40";
            counter = 0;
            this.Hide();
            CashOutForm cashOut = new CashOutForm();
            cashOut.Show();
        }


        private void XC60picbox_Click(object sender, EventArgs e)
        {
            model = "Volvo XC60";
            counter = 1;
            this.Hide();
            CashOutForm cashOut = new CashOutForm();
            cashOut.Show();
        }

        private void XC90picbox_Click(object sender, EventArgs e)
        {
            model = "Volvo XC90";
            counter = 2;
            this.Hide();
            CashOutForm cashOut = new CashOutForm();
            cashOut.Show();
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
