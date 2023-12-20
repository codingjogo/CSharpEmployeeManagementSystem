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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = true;
            addEmployeeUserControl1.Visible= false;
            salaryUserControl1.Visible = false;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = false;
            addEmployeeUserControl1.Visible = true;
            salaryUserControl1.Visible = false;
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = false;
            addEmployeeUserControl1.Visible = false;
            salaryUserControl1.Visible = true;
        }
    }
}
