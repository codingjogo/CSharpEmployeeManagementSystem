using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void showpassSignupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordTxtbox.PasswordChar = showpassSignupCheckbox.Checked ? '\0' : '*';
        }

        private void closeSignupLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
