using System.Data;
using System.Data.SqlClient;

namespace SDA_DBMS_Project.Forms
{
    public partial class FormReporting : Form
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

        public void panelHide()
        {
            pnlApprovedLeave.Visible = false;
            pnlAttendanceUpdate.Visible = false;
            pnlLeaveBalance.Visible = false;
            pnlLeaveRequest.Visible = false;
        }

        public FormReporting()
        {
            InitializeComponent();
            LoadTheme();
            panelHide();
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
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnLeaveRequestView_Click(object sender, EventArgs e)
        {
            panelHide();
            pnlLeaveRequest.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM LeaveRequestsView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridLeaveRequest.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying leave request view: " + ex.Message);
            }
        }

        private void btnLeaveBalanceView_Click(object sender, EventArgs e)
        {
            panelHide();
            pnlLeaveBalance.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM LeaveBalancesView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridLeaveRequest.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying leave balance view: " + ex.Message);
            }
        }

        private void btnApprovedLeaveView_Click(object sender, EventArgs e)
        {
            panelHide();
            pnlApprovedLeave.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM ApprovedLeaveView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridLeaveRequest.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying approved leave view: " + ex.Message);
            }
        }

        private void btnAttendanceUpdateView_Click(object sender, EventArgs e)
        {
            panelHide();
            pnlAttendanceUpdate.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM AttendanceUpdateView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridLeaveRequest.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying attendance update view: " + ex.Message);
            }
        }
    }
}
