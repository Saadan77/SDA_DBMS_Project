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
    public partial class Tables : Form
    {
        public class Connector
        {
            private static string connectionString = "Data Source=DESKTOP-77CH36A\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";

            public static SqlConnection GetConnection()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }

        public Tables()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabelPnl.SendToBack();
            attendanceLeaveMagPnl.BringToFront();
            
            
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
    }
}
