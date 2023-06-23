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
            hidePnls();
            panelDesktopPanel.Visible = true;
        }

        public void hidePnls()
        {
            pnlBenefits.Visible = false;
            pnlEmployee.Visible = false;
            panelDesktopPanel.Visible = false;
            pnlTimeAndAttendance.Visible = false;
            panelRecruitment.Visible = false;
            panelPayrollManagement.Visible = false;
            pnlPayrollAttenfdance.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidePnls();
            pnlEmployee.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
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

                    command.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textLastName.Text);
                    command.Parameters.AddWithValue("@DepartmentID", int.Parse(textDepartmentId.Text));
                    command.Parameters.AddWithValue("@Position", textPosition.Text);
                    command.Parameters.AddWithValue("@JoinDate", DateTime.Parse(textJoinDate.Text));
                    command.Parameters.AddWithValue("@TotalWorkingHours", float.Parse(textTotalHours.Text));
                    command.Parameters.AddWithValue("@AverageAttendanceHours", float.Parse(textAverageHours.Text));
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    if (!string.IsNullOrEmpty(textEmployeeId.Text))
                    {
                        string employeeId = textEmployeeId.Text;

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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("sp_UpdateEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@EmployeeID", int.Parse(textEmployeeId.Text));

                    if (!string.IsNullOrEmpty(textFirstName.Text))
                        command.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                    else
                        command.Parameters.AddWithValue("@FirstName", DBNull.Value);

                    if (!string.IsNullOrEmpty(textLastName.Text))
                        command.Parameters.AddWithValue("@LastName", textLastName.Text);
                    else
                        command.Parameters.AddWithValue("@LastName", DBNull.Value);

                    // Add more parameters and corresponding textboxes here

                    if (!string.IsNullOrEmpty(textDepartmentId.Text))
                        command.Parameters.AddWithValue("@DepartmentID", int.Parse(textDepartmentId.Text));
                    else
                        command.Parameters.AddWithValue("@DepartmentID", DBNull.Value);

                    if (!string.IsNullOrEmpty(textPosition.Text))
                        command.Parameters.AddWithValue("@Position", textPosition.Text);
                    else
                        command.Parameters.AddWithValue("@Position", DBNull.Value);

                    if (!string.IsNullOrEmpty(textJoinDate.Text))
                        command.Parameters.AddWithValue("@JoinDate", DateTime.Parse(textJoinDate.Text));
                    else
                        command.Parameters.AddWithValue("@JoinDate", DBNull.Value);

                    if (!string.IsNullOrEmpty(textTotalHours.Text))
                        command.Parameters.AddWithValue("@TotalWorkingHours", decimal.Parse(textTotalHours.Text));
                    else
                        command.Parameters.AddWithValue("@TotalWorkingHours", DBNull.Value);

                    if (!string.IsNullOrEmpty(textAverageHours.Text))
                        command.Parameters.AddWithValue("@AverageAttendanceHours", decimal.Parse(textAverageHours.Text));
                    else
                        command.Parameters.AddWithValue("@AverageAttendanceHours", DBNull.Value);

                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data succesfully updated");

                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM Employee", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridAttendanceLeave.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating employee data: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("sp_InsertBenefitsManagement", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BenefitID", txtBenefitId.Text);
                    command.Parameters.AddWithValue("@EmployeeID", txtEmployeeId.Text);
                    command.Parameters.AddWithValue("@BenefitType", txtBenefitType.Text);
                    command.Parameters.AddWithValue("@Description", txtBenefitType.Text);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtStartDate.Text));
                    command.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtEndDate.Text));
                    command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text)); command.ExecuteNonQuery();

                    MessageBox.Show("Data succesfully inserted");

                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM BenefitsManagement", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridBenefitsManagement.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting benefits data: " + ex.Message);
            }
        }

        private void btnBenefits_Click(object sender, EventArgs e)
        {
            hidePnls();
            pnlBenefits.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM BenefitsManagement", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridBenefitsManagement.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Leave Usage View: " + ex.Message);
            }
        }

        private void btnUpdateBenefit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("sp_UpdateBenefitManagement", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BenefitID", txtBenefitId.Text);
                    command.Parameters.AddWithValue("@EmployeeID", int.Parse(textEmployeeId.Text));

                    if (!string.IsNullOrEmpty(txtStartDate.Text))
                        command.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtStartDate.Text));

                    if (!string.IsNullOrEmpty(txtEndDate.Text))
                        command.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtEndDate.Text));

                    if (!string.IsNullOrEmpty(txtAmount.Text))
                        command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data succesfully deleted");

                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM BenefitsManagement", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridBenefitsManagement.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting benefits data: " + ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pnlTimeAndAttendance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimeAndAttendance_Click(object sender, EventArgs e)
        {
            hidePnls();
            pnlTimeAndAttendance.Visible = true;
        }

        private void btnRecruitement_Click(object sender, EventArgs e)
        {
            hidePnls();
            panelRecruitment.Visible = true;
        }

        private void panelPayrollManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void panelRecruitment_Click(object sender, EventArgs e)
        {
            

        }

        private void btnPayrollManagement_Click(object sender, EventArgs e)
        {
            hidePnls();
            panelPayrollManagement.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void btnPayrollAttendance_Click(object sender, EventArgs e)
        {
            hidePnls();
            pnlPayrollAttenfdance.Visible = true;
        }
    }
}
