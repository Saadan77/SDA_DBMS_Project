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
    public partial class FormPayrollProcessing : Form
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
        public FormPayrollProcessing()
        {
            InitializeComponent();
            LoadTheme();
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
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormPayrollProcessing_Load(object sender, EventArgs e)
        {

        }

        private void btnPayrollExpenseView_Click(object sender, EventArgs e)
        {
            pnlClockInOut.Visible = true;
            pnlPayrollExpenseView.Visible = false;
            pnlLeaveUsageView.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM PayrollExpenseView", connection);
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
    }
}
