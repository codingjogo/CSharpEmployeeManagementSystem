using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Lifetime;

namespace EmployeeManagementSystem
{
    public partial class SignupForm : Form
    {
        // Step 1 - setting up a connection
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jogod\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Step 2 - setting up a connection
            if (newUsernameTxtbox.Text == "" || newPasswordTxtbox.Text == "")
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ckeck state
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        // open connection state
                        connection.Open();

                        // checks if the id of user is already exist
                        string selectUsernameQuery = "SELECT COUNT(ID) FROM Users WHERE username = @user";

                        using (SqlCommand checkUserCmd = new SqlCommand(selectUsernameQuery, connection))
                        {
                            checkUserCmd.Parameters.AddWithValue("@user", newUsernameTxtbox.Text.Trim());

                            int count = (int) checkUserCmd.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(newUsernameTxtbox.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else
                            {
                                DateTime today = DateTime.Now;

                                // query to add new row (data) in Users (table)
                                string newUserDataQuery = $"INSERT INTO Users" +
                                    $"(username, password, date_register)" +
                                    $"VALUES (@username, @password, @date_register)"; // is == sqlCommand.Parameters.AddWithValue("@username", newUsernameTxtbox.Text.Trim());

                                using (SqlCommand sqlCommand = new SqlCommand(newUserDataQuery, connection))
                                {
                                    sqlCommand.Parameters.AddWithValue("@username", newUsernameTxtbox.Text.Trim());
                                    sqlCommand.Parameters.AddWithValue("@password", newPasswordTxtbox.Text.Trim());
                                    sqlCommand.Parameters.AddWithValue("@date_register", today);

                                    sqlCommand.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
