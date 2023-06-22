namespace SDA_DBMS_Project.Forms
{
    partial class FormReportModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportModule));
            panel2 = new Panel();
            btnAttendanceView = new Button();
            btnLeaveView = new Button();
            btnPayrollExpenseView = new Button();
            pnlLeaveManagement = new Panel();
            pnlLeaveUsage = new Panel();
            gridLeaveUsage = new DataGridView();
            pnlPayrollExpense = new Panel();
            gridPayrollExpense = new DataGridView();
            pnlEmployeeAttendance = new Panel();
            gridEmployeeAttendance = new DataGridView();
            panel2.SuspendLayout();
            pnlLeaveManagement.SuspendLayout();
            pnlLeaveUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLeaveUsage).BeginInit();
            pnlPayrollExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayrollExpense).BeginInit();
            pnlEmployeeAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEmployeeAttendance).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(btnAttendanceView);
            panel2.Controls.Add(btnLeaveView);
            panel2.Controls.Add(btnPayrollExpenseView);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 748);
            panel2.TabIndex = 32;
            // 
            // btnAttendanceView
            // 
            btnAttendanceView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAttendanceView.FlatAppearance.BorderSize = 0;
            btnAttendanceView.FlatStyle = FlatStyle.Flat;
            btnAttendanceView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttendanceView.ForeColor = Color.Gainsboro;
            btnAttendanceView.Image = (Image)resources.GetObject("btnAttendanceView.Image");
            btnAttendanceView.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendanceView.Location = new Point(2, 496);
            btnAttendanceView.Margin = new Padding(4, 5, 4, 5);
            btnAttendanceView.Name = "btnAttendanceView";
            btnAttendanceView.Size = new Size(304, 118);
            btnAttendanceView.TabIndex = 32;
            btnAttendanceView.Text = " Employees Attendance";
            btnAttendanceView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendanceView.UseVisualStyleBackColor = true;
            btnAttendanceView.Click += btnAttendanceView_Click;
            // 
            // btnLeaveView
            // 
            btnLeaveView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeaveView.FlatAppearance.BorderSize = 0;
            btnLeaveView.FlatStyle = FlatStyle.Flat;
            btnLeaveView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaveView.ForeColor = Color.Gainsboro;
            btnLeaveView.Image = (Image)resources.GetObject("btnLeaveView.Image");
            btnLeaveView.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeaveView.Location = new Point(6, 318);
            btnLeaveView.Margin = new Padding(4, 5, 4, 5);
            btnLeaveView.Name = "btnLeaveView";
            btnLeaveView.Size = new Size(304, 118);
            btnLeaveView.TabIndex = 31;
            btnLeaveView.Text = "   Leave Usage";
            btnLeaveView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeaveView.UseVisualStyleBackColor = true;
            btnLeaveView.Click += btnLeaveView_Click;
            // 
            // btnPayrollExpenseView
            // 
            btnPayrollExpenseView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPayrollExpenseView.FlatAppearance.BorderSize = 0;
            btnPayrollExpenseView.FlatStyle = FlatStyle.Flat;
            btnPayrollExpenseView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayrollExpenseView.ForeColor = Color.Gainsboro;
            btnPayrollExpenseView.Image = (Image)resources.GetObject("btnPayrollExpenseView.Image");
            btnPayrollExpenseView.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayrollExpenseView.Location = new Point(2, 134);
            btnPayrollExpenseView.Margin = new Padding(4, 5, 4, 5);
            btnPayrollExpenseView.Name = "btnPayrollExpenseView";
            btnPayrollExpenseView.Size = new Size(304, 118);
            btnPayrollExpenseView.TabIndex = 30;
            btnPayrollExpenseView.Text = "   Payroll Expense";
            btnPayrollExpenseView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayrollExpenseView.UseVisualStyleBackColor = true;
            btnPayrollExpenseView.Click += btnPayrollExpenseView_Click;
            // 
            // pnlLeaveManagement
            // 
            pnlLeaveManagement.Controls.Add(pnlLeaveUsage);
            pnlLeaveManagement.Controls.Add(pnlPayrollExpense);
            pnlLeaveManagement.Controls.Add(pnlEmployeeAttendance);
            pnlLeaveManagement.Location = new Point(312, 66);
            pnlLeaveManagement.Margin = new Padding(4, 5, 4, 5);
            pnlLeaveManagement.Name = "pnlLeaveManagement";
            pnlLeaveManagement.Size = new Size(1057, 617);
            pnlLeaveManagement.TabIndex = 33;
            // 
            // pnlLeaveUsage
            // 
            pnlLeaveUsage.Controls.Add(gridLeaveUsage);
            pnlLeaveUsage.Location = new Point(6, 0);
            pnlLeaveUsage.Name = "pnlLeaveUsage";
            pnlLeaveUsage.Size = new Size(1100, 613);
            pnlLeaveUsage.TabIndex = 3;
            // 
            // gridLeaveUsage
            // 
            gridLeaveUsage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLeaveUsage.Location = new Point(159, 108);
            gridLeaveUsage.Name = "gridLeaveUsage";
            gridLeaveUsage.RowHeadersWidth = 62;
            gridLeaveUsage.RowTemplate.Height = 33;
            gridLeaveUsage.Size = new Size(740, 353);
            gridLeaveUsage.TabIndex = 0;
            // 
            // pnlPayrollExpense
            // 
            pnlPayrollExpense.Controls.Add(gridPayrollExpense);
            pnlPayrollExpense.Location = new Point(3, 0);
            pnlPayrollExpense.Name = "pnlPayrollExpense";
            pnlPayrollExpense.Size = new Size(1100, 613);
            pnlPayrollExpense.TabIndex = 3;
            // 
            // gridPayrollExpense
            // 
            gridPayrollExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPayrollExpense.Location = new Point(164, 108);
            gridPayrollExpense.Name = "gridPayrollExpense";
            gridPayrollExpense.RowHeadersWidth = 62;
            gridPayrollExpense.RowTemplate.Height = 33;
            gridPayrollExpense.Size = new Size(740, 353);
            gridPayrollExpense.TabIndex = 2;
            // 
            // pnlEmployeeAttendance
            // 
            pnlEmployeeAttendance.Controls.Add(gridEmployeeAttendance);
            pnlEmployeeAttendance.Location = new Point(0, 0);
            pnlEmployeeAttendance.Name = "pnlEmployeeAttendance";
            pnlEmployeeAttendance.Size = new Size(1103, 613);
            pnlEmployeeAttendance.TabIndex = 3;
            // 
            // gridEmployeeAttendance
            // 
            gridEmployeeAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmployeeAttendance.Location = new Point(164, 108);
            gridEmployeeAttendance.Name = "gridEmployeeAttendance";
            gridEmployeeAttendance.RowHeadersWidth = 62;
            gridEmployeeAttendance.RowTemplate.Height = 33;
            gridEmployeeAttendance.Size = new Size(740, 353);
            gridEmployeeAttendance.TabIndex = 0;
            // 
            // FormReportModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 748);
            Controls.Add(pnlLeaveManagement);
            Controls.Add(panel2);
            Name = "FormReportModule";
            Text = "FormReportModule";
            panel2.ResumeLayout(false);
            pnlLeaveManagement.ResumeLayout(false);
            pnlLeaveUsage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLeaveUsage).EndInit();
            pnlPayrollExpense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPayrollExpense).EndInit();
            pnlEmployeeAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridEmployeeAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel pnlLeaveManagement;
        private Panel pnlLeaveUsage;
        private DataGridView gridLeaveUsage;
        private Panel pnlPayrollExpense;
        private DataGridView gridPayrollExpense;
        private Panel pnlEmployeeAttendance;
        private DataGridView gridEmployeeAttendance;
        private Button btnAttendanceView;
        private Button btnLeaveView;
        private Button btnPayrollExpenseView;
    }
}