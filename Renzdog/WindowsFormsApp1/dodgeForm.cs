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
    public partial class dodgeForm : Form
    {
        public dodgeForm()
        {
            InitializeComponent();
        }

        private void dodgeRTPicBox_Click(object sender, EventArgs e)
        {
            model = "Dodge Charger RT";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void dodgeSXTPicBox_Click(object sender, EventArgs e)
        {
            model = "Dodge Charger SXT";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void dodgeGTPicBox_Click(object sender, EventArgs e)
        {
            model = "Dodge Charger GT";
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

        private void backPicBox_Click(object sender, EventArgs e)
        {

            CarBrands carBrandForm = new CarBrands();
            this.Hide();
            carBrandForm.Show();
        }
    }
}
