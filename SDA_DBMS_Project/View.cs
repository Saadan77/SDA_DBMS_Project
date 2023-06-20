using System.Data;
using System.Data.SqlClient;

namespace SDA_DBMS_Project
{
    public partial class View : Form
    {
        public class DBHelper
        {
            private static string connectionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;User ID=Saadan;Password=Saadanbinjawad$500";

            public static SqlConnection GetConnection()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
        public View()
        {
            InitializeComponent();

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;User ID=Saadan;Password=Saadanbinjawad$500";
            cnn = new SqlConnection(connetionString);

            try
            {
                using (SqlConnection connection = DBHelper.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string query = "SELECT * FROM Employee";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void avg_atdBtn_Click(object sender, EventArgs e)
        {
            /*avgPanel.Visible = true;
            payrollPanel.Visible = false;
            totalWorkingPanel.Visible = false;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;User ID=Saadan;Password=Saadanbinjawad$500";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                cnn.Close();

                string query = "SELECT * FROM vw_average_attendance_rate";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnn);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            /*avgPanel.Visible = false;
            payrollPanel.Visible = true;
            totalWorkingPanel.Visible = false;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;User ID=Saadan;Password=Saadanbinjawad$500";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                cnn.Close();

                string query = "SELECT * FROM vw_payroll_summary";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnn);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*avgPanel.Visible = false;
            payrollPanel.Visible = false;
            totalWorkingPanel.Visible = true;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;User ID=Saadan;Password=Saadanbinjawad$500";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                cnn.Close();

                string query = "SELECT * FROM vw_total_working_hours";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnn);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }
    }
}
