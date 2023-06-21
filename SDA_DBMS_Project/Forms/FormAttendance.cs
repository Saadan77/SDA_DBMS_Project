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
    public partial class FormAttendance : Form
    {
        public class Connector
        {
            public static SqlConnection GetConnection()
            {
                string connectionString = "Data Source=DESKTOP-TV1A0O3\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
        public FormAttendance()
        {
            InitializeComponent();
            LoadTheme();
            pnlOverview.Visible = false;
            pnlBreakView.Visible = false;
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
            //lblTitle.ForeColor = ThemeColor.SecondaryColor;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {

        }

        private void btnClockInOutView_Click(object sender, EventArgs e)
        {
            pnlClockInOut.Visible = true;
            pnlOverview.Visible = false;
            pnlBreakView.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM ClockInOutView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridClockView.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Clock In Out View: " + ex.Message);
            }
        }

        private void btnBreakDurationView_Click(object sender, EventArgs e)
        {
            
            pnlBreakView.Visible = true;
            pnlClockInOut.Visible = false;
            pnlOverview.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM BreakDurationView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridBreakView.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Break View: " + ex.Message);
            }
        }

        private void btnOvertimeHoursView_Click(object sender, EventArgs e)
        {
            
            pnlOverview.Visible = true;
            pnlBreakView.Visible = false;
            pnlClockInOut.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM OvertimeCalculationView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridOvertime.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Overtime Calculation View: " + ex.Message);
            }
        }
    }
}
