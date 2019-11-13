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
    public partial class Karbro : Form
    {
        public Karbro()
        {
            InitializeComponent();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            LogInForm LoginForm = new LogInForm();
            LoginForm.Show();
            this.Close();
        }
    }
}
