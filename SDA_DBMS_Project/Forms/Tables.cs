using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_DBMS_Project.Forms
{
    public partial class Tables : Form
    {
        public class Connector
        {
            public static SqlConnection GetConnection()
            {
                string connectionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;Persist Security Info=True;User ID=Saadan;Password=Saadanbinjawad$500";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        public Tables()
        {
            InitializeComponent();
            pnlAttendanceLeave.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlAttendanceLeave.Visible = true;


            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    //MessageBox.Show("Success");
                    SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridAttendanceLeave.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Leave Usage View: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPcalculation_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlAttendanceLeave_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("sp_insert_employee", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", textEmployeeId.Text);
                    command.Parameters.AddWithValue("@LastName", textWokingDays.Text);
                    command.Parameters.AddWithValue("@DepartmentID", int.Parse(textPresentDays.Text));
                    command.Parameters.AddWithValue("@Position", textAbsentDays.Text);
                    command.Parameters.AddWithValue("@JoinDate", DateTime.Parse(textLeaveDays.Text));
                    command.Parameters.AddWithValue("@TotalWorkingHours", float.Parse(textLateArival.Text));
                    command.Parameters.AddWithValue("@AverageAttendanceHours", float.Parse(textRegularHrs.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data succesfully inserted");

                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM Employee", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridAttendanceLeave.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting employee data: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    if (!string.IsNullOrEmpty(textEmployeeDel.Text))
                    {
                        string employeeId = textEmployeeDel.Text;

                        try
                        {
                            SqlCommand deleteLeaveCommand = new SqlCommand("DELETE FROM Leave WHERE EmployeeID = @EmployeeID", connection);
                            deleteLeaveCommand.Parameters.AddWithValue("@EmployeeID", employeeId);
                            deleteLeaveCommand.ExecuteNonQuery();

                            SqlCommand command = new SqlCommand("sp_delete_employee", connection);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@EmployeeID", employeeId);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Employee with ID " + employeeId + " has been deleted successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while deleting the employee: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an employee ID to delete.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting employee data: " + ex.Message);
            }
        }
    }
}
