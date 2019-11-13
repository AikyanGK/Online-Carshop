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
    public partial class CarBrands : Form
    {
        public CarBrands()
        {
            InitializeComponent();
        }
        private void bmwPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "BMW";
            bmwForm bmwForm = new bmwForm();
            this.Hide();
            bmwForm.Show();
        }
        private void volvopicbox_Click(object sender, EventArgs e)
        {
            carbrand = "Volvo";
            volvoForm volvoForm = new volvoForm();
            this.Hide();
            volvoForm.Show();
        }
        private void ferrariPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Ferrari";
            ferrariForm ferrariForm = new ferrariForm();
            this.Hide();
            ferrariForm.Show();
        }
        private void jaguarPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Jaguar";
            jaguarForm jaguarForm = new jaguarForm();
            this.Hide();
            jaguarForm.Show();
        }
        private void fordPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Ford";
            fordForm fordForm = new fordForm();
            this.Hide();
            fordForm.Show();
        }
        private void lamborghiniPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Lamborghini";
            lamborghiniForm lamborghiniForm = new lamborghiniForm();
            this.Hide();
            lamborghiniForm.Show();
        }
        private void audiPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Audi";
            audiForm audiForm = new audiForm();
            this.Hide();
            audiForm.Show();
        }
        private void hondaPicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Honda";
            hondaForm hondaForm = new hondaForm();
            this.Hide();
            hondaForm.Show();
        }
        private void porschePicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Porsche";
            porscheForm porscheForm = new porscheForm();
            this.Hide();
            porscheForm.Show();
        }
        private void dodgePicBox_Click(object sender, EventArgs e)
        {
            carbrand = "Dodge";
            dodgeForm dodgeForm = new dodgeForm();
            this.Hide();
            dodgeForm.Show();
        }

        public static string carbrand = " ";

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }

    }
}
