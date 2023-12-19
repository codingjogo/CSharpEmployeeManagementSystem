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
            if (string.IsNullOrEmpty(newUsernameTxtbox.Text) || string.IsNullOrEmpty(newPasswordTxtbox.Text))
            {
                MessageBox.Show("Please fill in blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();

                    if (IsUsernameTaken(connection, newUsernameTxtbox.Text.Trim()))
                    {
                        MessageBox.Show($"{newUsernameTxtbox.Text.Trim()} is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RegisterUser(connection, newUsernameTxtbox.Text.Trim(), newPasswordTxtbox.Text.Trim());
                        MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine("Error: " + ex);
                    MessageBox.Show("An error occurred while processing your request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Function to check if the username is already taken
        private bool IsUsernameTaken(SqlConnection connection, string username)
        {
            string selectUsernameQuery = "SELECT COUNT(ID) FROM Users WHERE username = @user";

            using (SqlCommand checkUserCmd = new SqlCommand(selectUsernameQuery, connection))
            {
                checkUserCmd.Parameters.AddWithValue("@user", username);

                int count = (int)checkUserCmd.ExecuteScalar();
                return count >= 1;
            }
        }

        // Function to register a new user
        private void RegisterUser(SqlConnection connection, string username, string password)
        {
            string newUserDataQuery = "INSERT INTO Users (username, password, date_register) VALUES (@username, @password, @date_register)";

            using (SqlCommand sqlCommand = new SqlCommand(newUserDataQuery, connection))
            {
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@date_register", DateTime.Now);

                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
