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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            customer = 0;
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            Accounts.AccountDetails Access = new Accounts.AccountDetails();
            string[] usernameVerify = Access.userName;
            string[] passwordVerify = Access.password;

            int x = 0, y = 0;
            if (string.IsNullOrEmpty(UsernameTxtBox.Text))
            {
                MessageBox.Show("     Username field can't be empty.");
            }
            else
            {
                if (string.IsNullOrEmpty(passwordTxtBox.Text))
                {
                    MessageBox.Show("     Password field can't be empty.");
                }
                else
                {
                    try
                    {
                    usernameVer:
                        if (UsernameTxtBox.Text == usernameVerify[x])
                        {
                        passwordVer:
                            if (passwordTxtBox.Text == passwordVerify[y])
                            {
                                CarBrands carBrandForm = new CarBrands();
                                this.Hide();
                                carBrandForm.Show();                               
                            }
                            else
                            {
                                y++;
                                customer++;
                                goto passwordVer;                               
                            }
                        }
                        else
                        {
                            x++;
                            goto usernameVer;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("     Incorrect username/password.");
                        y = 0;
                        x = 0;
                        customer = 0;
                        UsernameTxtBox.Clear();
                        passwordTxtBox.Clear();
                    }
                }
            }
              
            
        }

       // counter
       public static int customer = 0;
    }
}
