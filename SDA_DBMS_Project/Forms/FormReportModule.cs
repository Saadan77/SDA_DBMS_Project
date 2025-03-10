﻿using System;
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
    public partial class FormReportModule : Form
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

        public FormReportModule()
        {
            InitializeComponent();

            pnlEmployeeAttendance.Visible = false;
            pnlLeaveUsage.Visible = false;
            pnlPayrollExpense.Visible = false;
        }

        private void btnPayrollExpenseView_Click(object sender, EventArgs e)
        {
            pnlEmployeeAttendance.Visible = false;
            pnlLeaveUsage.Visible = false;
            pnlPayrollExpense.Visible = true;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM PayrollExpenseView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridPayrollExpense.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying payroll expense view: " + ex.Message);
            }
        }

        private void btnLeaveView_Click(object sender, EventArgs e)
        {
            pnlEmployeeAttendance.Visible = false;
            pnlLeaveUsage.Visible = true;
            pnlPayrollExpense.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM LeaveUsageView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridLeaveUsage.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Leave usage view: " + ex.Message);
            }
        }

        private void btnAttendanceView_Click(object sender, EventArgs e)
        {
            pnlEmployeeAttendance.Visible = true;
            pnlLeaveUsage.Visible = false;
            pnlPayrollExpense.Visible = false;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM EmployeeAttendanceView", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridEmployeeAttendance.DataSource = dataTable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying Employee Attendance view: " + ex.Message);
            }
        }
    }

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

    /*private void LoadTheme()
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
    }*/
}
