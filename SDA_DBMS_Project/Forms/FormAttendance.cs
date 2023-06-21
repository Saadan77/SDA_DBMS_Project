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
                string connectionString = "Data Source=SAADAN2001\\SAADANSQL;Initial Catalog=Employees;Persist Security Info=True;User ID=Saadan;Password=Saadanbinjawad$500";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
        public FormAttendance()
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
            //lblTitle.ForeColor = ThemeColor.SecondaryColor;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {

        }
    }
}
