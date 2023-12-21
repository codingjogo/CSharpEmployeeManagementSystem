using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AddEmployeeUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jogod\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public AddEmployeeUserControl()
        {
            InitializeComponent();

            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData employeeData = new EmployeeData();
            List<EmployeeData> employees = employeeData.employeeListData();

            employeeData_dgv.DataSource = employees;
        }

        public void clearFields()
        {
            addEmployee_id_txtbox.Clear();
            addEmployee_fullname_txtbox.Clear();
            addEmployee_gender_cmb.SelectedIndex = -1;
            addEmployee_phoneNo_txtbox.Clear();
            addEmployee_position_cmb.SelectedIndex = -1;
            addEmployee_status_cmb.SelectedIndex = -1;
            addEmployee_picture_picBox.Image = null;
        }

        private void addEmployee_add_button_Click(object sender, EventArgs e)
        {
            if (addEmployee_id_txtbox.Text == "" || addEmployee_fullname_txtbox.Text == "" || addEmployee_gender_cmb.Text == "" || addEmployee_phoneNo_txtbox.Text == "" || addEmployee_position_cmb.Text == "" || addEmployee_status_cmb.Text == "" || addEmployee_picture_picBox.Image == null)
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        string checkEmployeeIDIfExistsQuery = "SELECT COUNT(*) FROM employees WHERE employee_id = @employeeID";



                        using (SqlCommand cmd = new SqlCommand(checkEmployeeIDIfExistsQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("employeeID", addEmployee_id_txtbox.Text.Trim());
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(addEmployee_id_txtbox.Text.Trim() + " is already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Now;

                                string insertNewEmployeeQuery = "INSERT INTO employees (employee_id, full_name, gender, contact_number, position, image, insert_date, status) VALUES (@employeeID, @name, @gender, @contactNo, @position, @image, @insert_date, @status)";

                                string path = Path.Combine(@"C:\Users\jogod\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Directory\" + addEmployee_id_txtbox.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture_picBox.ImageLocation, path, true);

                                using (SqlCommand insertNewEmployeeQueryCommand = new SqlCommand(insertNewEmployeeQuery, connection))
                                {
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@employeeID", addEmployee_id_txtbox.Text.Trim());
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@name", addEmployee_fullname_txtbox.Text.Trim());
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@gender", addEmployee_gender_cmb.Text.Trim());
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@contactNo", addEmployee_phoneNo_txtbox.Text.Trim());
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@position", addEmployee_position_cmb.Text.Trim());
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@image", path);
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@insert_date", today);
                                    insertNewEmployeeQueryCommand.Parameters.AddWithValue("@status", addEmployee_status_cmb.Text.Trim());

                                    insertNewEmployeeQueryCommand.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connection.Close(); }
                }
            }
        }

        private void addEmployee_uploadPic_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                string imagePath = "";

                openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    addEmployee_picture_picBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Message Error", MessageBoxButtons.OK,

                    MessageBoxIcon.Error);
            }
        }

        private void employeeData_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = employeeData_dgv.Rows[e.RowIndex];
            addEmployee_id_txtbox.Text = row.Cells[1].Value.ToString();
            addEmployee_fullname_txtbox.Text = row.Cells[2].Value.ToString();
            addEmployee_gender_cmb.Text = row.Cells[3].Value.ToString();
            addEmployee_phoneNo_txtbox.Text = row.Cells[4].Value.ToString();
            addEmployee_position_cmb.Text = row.Cells[5].Value.ToString();

            string imagePath = row.Cells[6].Value.ToString();

            if (imagePath != null)
            {
                addEmployee_picture_picBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                addEmployee_picture_picBox.Image = null;
            }

            addEmployee_status_cmb.Text = row.Cells[8].Value.ToString();
        }

        private void addEmployee_update_button_Click(object sender, EventArgs e)
        {
            /*TODO:
             * UPDATE IMAGE
            */
            if (addEmployee_id_txtbox.Text == "" || addEmployee_fullname_txtbox.Text == "" || addEmployee_gender_cmb.Text == "" || addEmployee_phoneNo_txtbox.Text == "" || addEmployee_position_cmb.Text == "" || addEmployee_status_cmb.Text == "" || addEmployee_picture_picBox.Image == null)
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to edit Employee ID: " + addEmployee_id_txtbox.Text.ToString(), "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        try
                        {
                            connection.Open();

                            DateTime today = DateTime.Now;

                            string updateEmployeeQuery = "UPDATE employees SET full_name = @full_name, gender = @gender, contact_number = @contact_number, position = @position, update_date = @update_date, status = @status WHERE employee_id = @employee_id";

                            using (SqlCommand updateCmd = new SqlCommand(updateEmployeeQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@employee_id", addEmployee_id_txtbox.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@full_name", addEmployee_fullname_txtbox.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@gender", addEmployee_gender_cmb.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@contact_number", addEmployee_phoneNo_txtbox.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@position", addEmployee_position_cmb.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@update_date", today);
                                updateCmd.Parameters.AddWithValue("@status", addEmployee_status_cmb.Text.Trim());

                                updateCmd.ExecuteNonQuery();

                                displayEmployeeData();

                                MessageBox.Show("Update Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { connection.Close(); }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addEmployee_clear_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_delete_button_Click(object sender, EventArgs e)
        {
            if (addEmployee_id_txtbox.Text == "" || addEmployee_fullname_txtbox.Text == "" || addEmployee_gender_cmb.Text == "" || addEmployee_phoneNo_txtbox.Text == "" || addEmployee_position_cmb.Text == "" || addEmployee_status_cmb.Text == "" || addEmployee_picture_picBox.Image == null)
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        DateTime today = DateTime.Now;

                        string deleteEmployeeQuery = "UPDATE employees SET delete_date = @delete_date WHERE employee_id = @employee_id";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteEmployeeQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@employee_id", addEmployee_id_txtbox.Text.Trim());
                            deleteCmd.Parameters.AddWithValue("@delete_date", today);

                            deleteCmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connection.Close(); }
                }
            }
        }
    }
}
