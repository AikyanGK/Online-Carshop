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
    public partial class bmwForm : Form
    {
        public bmwForm()
        {
            InitializeComponent();
       
        }

        private void bmwForm_Load(object sender, EventArgs e)
        {
            
        }
        private void X7Btn_Click(object sender, EventArgs e)
        {
            model = "BMW X7";
            counter = 0;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void BMWZ4PicBox_Click(object sender, EventArgs e)
        {
            model = "BMW Z4";
            counter = 1;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void BMWGTPicBox_Click(object sender, EventArgs e)
        {
            model = "BMW GT";
            counter = 2;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void BMW5Btn_Click(object sender, EventArgs e)
        {
            model = "BMW 5 Series";
            counter = 3;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void BMW4SCBtn_Click(object sender, EventArgs e)
        {
            model = "BMW 4 Series Coupe";
            counter = 4;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }

        private void X4Btn_Click(object sender, EventArgs e)
        {
            model = "BMW X4";
            counter = 5;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        public void BMW7Btn_Click(object sender, EventArgs e)
        {
            model = "BMW 7 Series";
            counter = 6;
            this.Hide();
            CashOutForm CashOut = new CashOutForm();
            CashOut.Show();
        }
        private void backPicBox_Click(object sender, EventArgs e)
        {
            CarBrands carBrandForm = new CarBrands();
            this.Hide();
            carBrandForm.Show();
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
