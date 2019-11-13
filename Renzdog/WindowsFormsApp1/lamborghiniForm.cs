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
    public partial class lamborghiniForm : Form
    {
        public lamborghiniForm()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }

        private void lamborghiniUrusPicBox_Click(object sender, EventArgs e)
        {
            model = "Lamborghini Urus";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void lamborghiniHuracanPicBox_Click(object sender, EventArgs e)
        {
            model = "Lamborghini Huracan";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void lamborghiniAventadorPicBox_Click(object sender, EventArgs e)
        {
            model = "Lamborghini Aventador";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        public static string model = " ";
        public static int counter = 0;

        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            this.Hide();
            carBrandForm.Show();
        }
    }
}
