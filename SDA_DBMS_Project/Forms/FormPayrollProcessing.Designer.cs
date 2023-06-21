namespace SDA_DBMS_Project.Forms
{
    partial class FormPayrollProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayrollProcessing));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmployeeAttendanceView = new System.Windows.Forms.Button();
            this.btnLeaveUsageView = new System.Windows.Forms.Button();
            this.btnPayrollExpenseView = new System.Windows.Forms.Button();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.gridOvertime = new System.Windows.Forms.DataGridView();
            this.pnlBreakView = new System.Windows.Forms.Panel();
            this.gridBreakView = new System.Windows.Forms.DataGridView();
            this.pnlClockInOut = new System.Windows.Forms.Panel();
            this.gridClockView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOvertime)).BeginInit();
            this.pnlBreakView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBreakView)).BeginInit();
            this.pnlClockInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClockView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnEmployeeAttendanceView);
            this.panel2.Controls.Add(this.btnLeaveUsageView);
            this.panel2.Controls.Add(this.btnPayrollExpenseView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 687);
            this.panel2.TabIndex = 30;
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
            this.btnEmployeeAttendanceView.Location = new System.Drawing.Point(3, 514);
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
            this.btnLeaveUsageView.Location = new System.Drawing.Point(3, 387);
            this.btnLeaveUsageView.Name = "btnLeaveUsageView";
            this.btnLeaveUsageView.Size = new System.Drawing.Size(216, 71);
            this.btnLeaveUsageView.TabIndex = 26;
            this.btnLeaveUsageView.Text = "   LeaveUsageView";
            this.btnLeaveUsageView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeaveUsageView.UseVisualStyleBackColor = true;
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
            this.btnPayrollExpenseView.Location = new System.Drawing.Point(0, 253);
            this.btnPayrollExpenseView.Name = "btnPayrollExpenseView";
            this.btnPayrollExpenseView.Size = new System.Drawing.Size(216, 71);
            this.btnPayrollExpenseView.TabIndex = 25;
            this.btnPayrollExpenseView.Text = "   PayrollExpenseView";
            this.btnPayrollExpenseView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayrollExpenseView.UseVisualStyleBackColor = true;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.gridOvertime);
            this.pnlOverview.Location = new System.Drawing.Point(386, 253);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(521, 317);
            this.pnlOverview.TabIndex = 31;
            // 
            // gridOvertime
            // 
            this.gridOvertime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOvertime.Location = new System.Drawing.Point(0, 0);
            this.gridOvertime.Name = "gridOvertime";
            this.gridOvertime.RowTemplate.Height = 25;
            this.gridOvertime.Size = new System.Drawing.Size(518, 317);
            this.gridOvertime.TabIndex = 0;
            // 
            // pnlBreakView
            // 
            this.pnlBreakView.Controls.Add(this.gridBreakView);
            this.pnlBreakView.Location = new System.Drawing.Point(386, 253);
            this.pnlBreakView.Name = "pnlBreakView";
            this.pnlBreakView.Size = new System.Drawing.Size(521, 320);
            this.pnlBreakView.TabIndex = 32;
            // 
            // gridBreakView
            // 
            this.gridBreakView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBreakView.Location = new System.Drawing.Point(0, 0);
            this.gridBreakView.Name = "gridBreakView";
            this.gridBreakView.RowTemplate.Height = 25;
            this.gridBreakView.Size = new System.Drawing.Size(518, 317);
            this.gridBreakView.TabIndex = 0;
            // 
            // pnlClockInOut
            // 
            this.pnlClockInOut.Controls.Add(this.gridClockView);
            this.pnlClockInOut.Location = new System.Drawing.Point(386, 259);
            this.pnlClockInOut.Name = "pnlClockInOut";
            this.pnlClockInOut.Size = new System.Drawing.Size(521, 314);
            this.pnlClockInOut.TabIndex = 33;
            // 
            // gridClockView
            // 
            this.gridClockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClockView.Location = new System.Drawing.Point(3, 3);
            this.gridClockView.Name = "gridClockView";
            this.gridClockView.RowTemplate.Height = 25;
            this.gridClockView.Size = new System.Drawing.Size(518, 308);
            this.gridClockView.TabIndex = 0;
            // 
            // FormPayrollProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlBreakView);
            this.Controls.Add(this.pnlClockInOut);
            this.Controls.Add(this.panel2);
            this.Name = "FormPayrollProcessing";
            this.Text = "FormPayrollProcessing";
            this.Load += new System.EventHandler(this.FormPayrollProcessing_Load);
            this.panel2.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOvertime)).EndInit();
            this.pnlBreakView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBreakView)).EndInit();
            this.pnlClockInOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClockView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel pnlOverview;
        private DataGridView gridOvertime;
        private Panel pnlBreakView;
        private DataGridView gridBreakView;
        private Panel pnlClockInOut;
        private DataGridView gridClockView;
        private Button btnEmployeeAttendanceView;
        private Button btnLeaveUsageView;
        private Button btnPayrollExpenseView;
    }
}