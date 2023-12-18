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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void showpassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxtbox.PasswordChar = showpassCheckbox.Checked ? '\0' : '*';
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
