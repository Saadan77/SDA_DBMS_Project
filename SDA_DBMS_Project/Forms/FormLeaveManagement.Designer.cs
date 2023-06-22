namespace SDA_DBMS_Project.Forms
{
    partial class FormLeaveManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeaveManagement));
            this.gridLeaveUsage = new System.Windows.Forms.DataGridView();
            this.pnlLeaveUsage = new System.Windows.Forms.Panel();
            this.gridPayrollExpense = new System.Windows.Forms.DataGridView();
            this.pnlPayrollExpense = new System.Windows.Forms.Panel();
            this.pnlEmployeeAttendance = new System.Windows.Forms.Panel();
            this.gridEmployeeAttendance = new System.Windows.Forms.DataGridView();
            this.pnlLeaveManagement = new System.Windows.Forms.Panel();
            this.btnPayrollExpenseView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAttendanceView = new System.Windows.Forms.Button();
            this.btnLeaveView = new System.Windows.Forms.Button();
            this.btnEmployeeAttendanceView = new System.Windows.Forms.Button();
            this.btnLeaveUsageView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeaveUsage)).BeginInit();
            this.pnlLeaveUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayrollExpense)).BeginInit();
            this.pnlPayrollExpense.SuspendLayout();
            this.pnlEmployeeAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeAttendance)).BeginInit();
            this.pnlLeaveManagement.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLeaveUsage
            // 
            this.gridLeaveUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeaveUsage.Location = new System.Drawing.Point(111, 65);
            this.gridLeaveUsage.Margin = new System.Windows.Forms.Padding(2);
            this.gridLeaveUsage.Name = "gridLeaveUsage";
            this.gridLeaveUsage.RowHeadersWidth = 62;
            this.gridLeaveUsage.RowTemplate.Height = 33;
            this.gridLeaveUsage.Size = new System.Drawing.Size(518, 212);
            this.gridLeaveUsage.TabIndex = 0;
            this.gridLeaveUsage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLeaveUsage_CellContentClick);
            // 
            // pnlLeaveUsage
            // 
            this.pnlLeaveUsage.Controls.Add(this.gridLeaveUsage);
            this.pnlLeaveUsage.Location = new System.Drawing.Point(4, 0);
            this.pnlLeaveUsage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeaveUsage.Name = "pnlLeaveUsage";
            this.pnlLeaveUsage.Size = new System.Drawing.Size(770, 368);
            this.pnlLeaveUsage.TabIndex = 3;
            // 
            // gridPayrollExpense
            // 
            this.gridPayrollExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPayrollExpense.Location = new System.Drawing.Point(115, 65);
            this.gridPayrollExpense.Margin = new System.Windows.Forms.Padding(2);
            this.gridPayrollExpense.Name = "gridPayrollExpense";
            this.gridPayrollExpense.RowHeadersWidth = 62;
            this.gridPayrollExpense.RowTemplate.Height = 33;
            this.gridPayrollExpense.Size = new System.Drawing.Size(518, 212);
            this.gridPayrollExpense.TabIndex = 2;
            // 
            // pnlPayrollExpense
            // 
            this.pnlPayrollExpense.Controls.Add(this.gridPayrollExpense);
            this.pnlPayrollExpense.Location = new System.Drawing.Point(2, 0);
            this.pnlPayrollExpense.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPayrollExpense.Name = "pnlPayrollExpense";
            this.pnlPayrollExpense.Size = new System.Drawing.Size(770, 368);
            this.pnlPayrollExpense.TabIndex = 3;
            // 
            // pnlEmployeeAttendance
            // 
            this.pnlEmployeeAttendance.Controls.Add(this.gridEmployeeAttendance);
            this.pnlEmployeeAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEmployeeAttendance.Name = "pnlEmployeeAttendance";
            this.pnlEmployeeAttendance.Size = new System.Drawing.Size(772, 368);
            this.pnlEmployeeAttendance.TabIndex = 3;
            // 
            // gridEmployeeAttendance
            // 
            this.gridEmployeeAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployeeAttendance.Location = new System.Drawing.Point(115, 65);
            this.gridEmployeeAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.gridEmployeeAttendance.Name = "gridEmployeeAttendance";
            this.gridEmployeeAttendance.RowHeadersWidth = 62;
            this.gridEmployeeAttendance.RowTemplate.Height = 33;
            this.gridEmployeeAttendance.Size = new System.Drawing.Size(518, 212);
            this.gridEmployeeAttendance.TabIndex = 0;
            // 
            // pnlLeaveManagement
            // 
            this.pnlLeaveManagement.Controls.Add(this.pnlLeaveUsage);
            this.pnlLeaveManagement.Controls.Add(this.pnlPayrollExpense);
            this.pnlLeaveManagement.Controls.Add(this.pnlEmployeeAttendance);
            this.pnlLeaveManagement.Location = new System.Drawing.Point(222, 80);
            this.pnlLeaveManagement.Name = "pnlLeaveManagement";
            this.pnlLeaveManagement.Size = new System.Drawing.Size(725, 370);
            this.pnlLeaveManagement.TabIndex = 23;
            // 
            // btnPayrollExpenseView
            // 
            this.btnPayrollExpenseView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayrollExpenseView.FlatAppearance.BorderSize = 0;
            this.btnPayrollExpenseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayrollExpenseView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayrollExpenseView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayrollExpenseView.Image = ((System.Drawing.Image)(resources.GetObject("btnPayrollExpenseView.Image")));
            this.btnPayrollExpenseView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayrollExpenseView.Location = new System.Drawing.Point(0, 119);
            this.btnPayrollExpenseView.Name = "btnPayrollExpenseView";
            this.btnPayrollExpenseView.Size = new System.Drawing.Size(213, 71);
            this.btnPayrollExpenseView.TabIndex = 26;
            this.btnPayrollExpenseView.Text = "   Payroll Expense";
            this.btnPayrollExpenseView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayrollExpenseView.UseVisualStyleBackColor = true;
            this.btnPayrollExpenseView.Click += new System.EventHandler(this.btnPayrollExpenseView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnAttendanceView);
            this.panel2.Controls.Add(this.btnLeaveView);
            this.panel2.Controls.Add(this.btnPayrollExpenseView);
            this.panel2.Controls.Add(this.btnEmployeeAttendanceView);
            this.panel2.Controls.Add(this.btnLeaveUsageView);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 449);
            this.panel2.TabIndex = 31;
            // 
            // btnAttendanceView
            // 
            this.btnAttendanceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttendanceView.FlatAppearance.BorderSize = 0;
            this.btnAttendanceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttendanceView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAttendanceView.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendanceView.Image")));
            this.btnAttendanceView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceView.Location = new System.Drawing.Point(0, 336);
            this.btnAttendanceView.Name = "btnAttendanceView";
            this.btnAttendanceView.Size = new System.Drawing.Size(213, 71);
            this.btnAttendanceView.TabIndex = 29;
            this.btnAttendanceView.Text = " Employees Attendance";
            this.btnAttendanceView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceView.UseVisualStyleBackColor = true;
            this.btnAttendanceView.Click += new System.EventHandler(this.btnAttendanceView_Click);
            // 
            // btnLeaveView
            // 
            this.btnLeaveView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeaveView.FlatAppearance.BorderSize = 0;
            this.btnLeaveView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeaveView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLeaveView.Image = ((System.Drawing.Image)(resources.GetObject("btnLeaveView.Image")));
            this.btnLeaveView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveView.Location = new System.Drawing.Point(3, 229);
            this.btnLeaveView.Name = "btnLeaveView";
            this.btnLeaveView.Size = new System.Drawing.Size(213, 71);
            this.btnLeaveView.TabIndex = 28;
            this.btnLeaveView.Text = "   Leave Usage";
            this.btnLeaveView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeaveView.UseVisualStyleBackColor = true;
            this.btnLeaveView.Click += new System.EventHandler(this.btnLeaveView_Click);
            // 
            // btnEmployeeAttendanceView
            // 
            this.btnEmployeeAttendanceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeAttendanceView.FlatAppearance.BorderSize = 0;
            this.btnEmployeeAttendanceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAttendanceView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeAttendanceView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeAttendanceView.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAttendanceView.Image")));
            this.btnEmployeeAttendanceView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeAttendanceView.Location = new System.Drawing.Point(19, 678);
            this.btnEmployeeAttendanceView.Name = "btnEmployeeAttendanceView";
            this.btnEmployeeAttendanceView.Size = new System.Drawing.Size(216, 71);
            this.btnEmployeeAttendanceView.TabIndex = 27;
            this.btnEmployeeAttendanceView.Text = "   EmployeeAttendance View";
            this.btnEmployeeAttendanceView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeAttendanceView.UseVisualStyleBackColor = true;
            // 
            // btnLeaveUsageView
            // 
            this.btnLeaveUsageView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeaveUsageView.FlatAppearance.BorderSize = 0;
            this.btnLeaveUsageView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveUsageView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeaveUsageView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLeaveUsageView.Image = ((System.Drawing.Image)(resources.GetObject("btnLeaveUsageView.Image")));
            this.btnLeaveUsageView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveUsageView.Location = new System.Drawing.Point(22, 567);
            this.btnLeaveUsageView.Name = "btnLeaveUsageView";
            this.btnLeaveUsageView.Size = new System.Drawing.Size(216, 71);
            this.btnLeaveUsageView.TabIndex = 26;
            this.btnLeaveUsageView.Text = "   LeaveUsageView";
            this.btnLeaveUsageView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeaveUsageView.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 71);
            this.button1.TabIndex = 25;
            this.button1.Text = "   PayrollExpenseView";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormLeaveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeaveManagement);
            this.Name = "FormLeaveManagement";
            this.Text = "FormReporting&Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.gridLeaveUsage)).EndInit();
            this.pnlLeaveUsage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPayrollExpense)).EndInit();
            this.pnlPayrollExpense.ResumeLayout(false);
            this.pnlEmployeeAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeAttendance)).EndInit();
            this.pnlLeaveManagement.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView gridLeaveUsage;
        private Panel pnlLeaveUsage;
        private DataGridView gridPayrollExpense;
        private Panel pnlPayrollExpense;
        private Panel pnlLeaveManagement;
        private Panel pnlEmployeeAttendance;
        private DataGridView gridEmployeeAttendance;
        private Button btnPayrollExpenseView;
        private Panel panel2;
        private Button btnEmployeeAttendanceView;
        private Button btnLeaveUsageView;
        private Button button1;
        private Button btnAttendanceView;
        private Button btnLeaveView;
    }
}