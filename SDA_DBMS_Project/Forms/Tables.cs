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
            private static string connectionString = "Data Source=DESKTOP-TV1A0O3\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";

            public static SqlConnection GetConnection()
            {
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
            lblAttendanceLeave.ForeColor = ThemeColor.SecondaryColor;
            
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
                    SqlCommand command = new SqlCommand("SELECT * FROM AttendanceAndLeaveManagement", connection);
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
    }
}
