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
    public partial class jaguarForm : Form
    {
        public jaguarForm()
        {
            InitializeComponent();
        }

        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            this.Hide();
            carBrandForm.Show();
        }
        private void jaguarEPace_Click(object sender, EventArgs e)
        {
            model = "Jaguar E Pace";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void jaguarXE_Click(object sender, EventArgs e)
        {
            model = "Jaguar XE";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void jaguarFType_Click(object sender, EventArgs e)
        {
            model = "Jaguar F Type";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void jaguarXJ_Click(object sender, EventArgs e)
        {
            model = "Jaguar XJ";
            counter = 3;
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
