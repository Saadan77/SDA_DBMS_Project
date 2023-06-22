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
    public partial class FormEmployeeManagement : Form
    {
        public class Connector
        {
            public static SqlConnection GetConnection()
            {
                string connectionString = "Data Source=DESKTOP-77CH36A\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";
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

        public FormEmployeeManagement()
        {
            InitializeComponent();
            LoadTheme();


        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridEmployeeView.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying payroll expense view: " + ex.Message);
            }
        }
    }
    
}
