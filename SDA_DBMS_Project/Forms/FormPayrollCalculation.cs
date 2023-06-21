using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_DBMS_Project.Forms
{
    public partial class FormPayrollCalculation : Form
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

        public FormPayrollCalculation()
        {
            InitializeComponent();
            LoadTheme();

            pnlPayrollReport.Visible = false;
            pnlPayslip.Visible = false;
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

        private void btnPayrollReport_Click(object sender, EventArgs e)
        {
            pnlPayrollReport.Visible = true;
            pnlPayslip.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM PayrollReportView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridPayrollReport.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying payroll report view: " + ex.Message);
            }
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            pnlPayrollReport.Visible = false;
            pnlPayslip.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM PayslipView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridPayslip.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying payroll slip view: " + ex.Message);
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            FormLeaveManagement openForm = new FormLeaveManagement();
            openForm.Show();
        }
    }
}
