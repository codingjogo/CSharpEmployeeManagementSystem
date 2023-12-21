using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public class EmployeeData
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jogod\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

         public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there are rows in the result set
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                EmployeeData employeedata = new EmployeeData();

                                employeedata.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                                employeedata.EmployeeID = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                employeedata.Name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                employeedata.Gender = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                employeedata.Contact = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                                employeedata.Position = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                                employeedata.Image = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                                employeedata.Salary = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                                employeedata.Status = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);

                                listdata.Add(employeedata);
                            }
                        }

                         
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }


            return listdata;
        }



    }
}
