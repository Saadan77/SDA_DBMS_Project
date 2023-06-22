namespace SDA_DBMS_Project.Forms
{
    partial class FormReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting));
            panel2 = new Panel();
            btnAttendanceUpdateView = new Button();
            btnApprovedLeaveView = new Button();
            btnLeaveBalanceView = new Button();
            btnLeaveRequestView = new Button();
            pnlLeaveManagement = new Panel();
            pnlAttendanceUpdate = new Panel();
            dataGridView1 = new DataGridView();
            pnlLeaveRequest = new Panel();
            gridLeaveRequest = new DataGridView();
            pnlLeaveBalance = new Panel();
            gridLeaveBalance = new DataGridView();
            pnlApprovedLeave = new Panel();
            gridAttendanceUpdate = new DataGridView();
            panel2.SuspendLayout();
            pnlLeaveManagement.SuspendLayout();
            pnlAttendanceUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlLeaveRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLeaveRequest).BeginInit();
            pnlLeaveBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLeaveBalance).BeginInit();
            pnlApprovedLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAttendanceUpdate).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(btnAttendanceUpdateView);
            panel2.Controls.Add(btnApprovedLeaveView);
            panel2.Controls.Add(btnLeaveBalanceView);
            panel2.Controls.Add(btnLeaveRequestView);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 750);
            panel2.TabIndex = 33;
            // 
            // btnAttendanceUpdateView
            // 
            btnAttendanceUpdateView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAttendanceUpdateView.FlatAppearance.BorderSize = 0;
            btnAttendanceUpdateView.FlatStyle = FlatStyle.Flat;
            btnAttendanceUpdateView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttendanceUpdateView.ForeColor = Color.Gainsboro;
            btnAttendanceUpdateView.Image = (Image)resources.GetObject("btnAttendanceUpdateView.Image");
            btnAttendanceUpdateView.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendanceUpdateView.Location = new Point(2, 439);
            btnAttendanceUpdateView.Margin = new Padding(4, 5, 4, 5);
            btnAttendanceUpdateView.Name = "btnAttendanceUpdateView";
            btnAttendanceUpdateView.Size = new Size(304, 118);
            btnAttendanceUpdateView.TabIndex = 30;
            btnAttendanceUpdateView.Text = "   Attendance Update";
            btnAttendanceUpdateView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendanceUpdateView.UseVisualStyleBackColor = true;
            btnAttendanceUpdateView.Click += btnAttendanceUpdateView_Click;
            // 
            // btnApprovedLeaveView
            // 
            btnApprovedLeaveView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApprovedLeaveView.FlatAppearance.BorderSize = 0;
            btnApprovedLeaveView.FlatStyle = FlatStyle.Flat;
            btnApprovedLeaveView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprovedLeaveView.ForeColor = Color.Gainsboro;
            btnApprovedLeaveView.Image = (Image)resources.GetObject("btnApprovedLeaveView.Image");
            btnApprovedLeaveView.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprovedLeaveView.Location = new Point(5, 311);
            btnApprovedLeaveView.Margin = new Padding(4, 5, 4, 5);
            btnApprovedLeaveView.Name = "btnApprovedLeaveView";
            btnApprovedLeaveView.Size = new Size(304, 118);
            btnApprovedLeaveView.TabIndex = 29;
            btnApprovedLeaveView.Text = "   Approved Leave";
            btnApprovedLeaveView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApprovedLeaveView.UseVisualStyleBackColor = true;
            btnApprovedLeaveView.Click += btnApprovedLeaveView_Click;
            // 
            // btnLeaveBalanceView
            // 
            btnLeaveBalanceView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeaveBalanceView.FlatAppearance.BorderSize = 0;
            btnLeaveBalanceView.FlatStyle = FlatStyle.Flat;
            btnLeaveBalanceView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaveBalanceView.ForeColor = Color.Gainsboro;
            btnLeaveBalanceView.Image = (Image)resources.GetObject("btnLeaveBalanceView.Image");
            btnLeaveBalanceView.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeaveBalanceView.Location = new Point(5, 183);
            btnLeaveBalanceView.Margin = new Padding(4, 5, 4, 5);
            btnLeaveBalanceView.Name = "btnLeaveBalanceView";
            btnLeaveBalanceView.Size = new Size(304, 118);
            btnLeaveBalanceView.TabIndex = 28;
            btnLeaveBalanceView.Text = "   Leave Balances";
            btnLeaveBalanceView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeaveBalanceView.UseVisualStyleBackColor = true;
            btnLeaveBalanceView.Click += btnLeaveBalanceView_Click;
            // 
            // btnLeaveRequestView
            // 
            btnLeaveRequestView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeaveRequestView.FlatAppearance.BorderSize = 0;
            btnLeaveRequestView.FlatStyle = FlatStyle.Flat;
            btnLeaveRequestView.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaveRequestView.ForeColor = Color.Gainsboro;
            btnLeaveRequestView.Image = (Image)resources.GetObject("btnLeaveRequestView.Image");
            btnLeaveRequestView.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeaveRequestView.Location = new Point(4, 55);
            btnLeaveRequestView.Margin = new Padding(4, 5, 4, 5);
            btnLeaveRequestView.Name = "btnLeaveRequestView";
            btnLeaveRequestView.Size = new Size(304, 118);
            btnLeaveRequestView.TabIndex = 27;
            btnLeaveRequestView.Text = "   Leave Request";
            btnLeaveRequestView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeaveRequestView.UseVisualStyleBackColor = true;
            btnLeaveRequestView.Click += btnLeaveRequestView_Click;
            // 
            // pnlLeaveManagement
            // 
            pnlLeaveManagement.Controls.Add(pnlAttendanceUpdate);
            pnlLeaveManagement.Controls.Add(pnlLeaveRequest);
            pnlLeaveManagement.Controls.Add(pnlLeaveBalance);
            pnlLeaveManagement.Controls.Add(pnlApprovedLeave);
            pnlLeaveManagement.Location = new Point(314, 0);
            pnlLeaveManagement.Margin = new Padding(4, 5, 4, 5);
            pnlLeaveManagement.Name = "pnlLeaveManagement";
            pnlLeaveManagement.Size = new Size(990, 750);
            pnlLeaveManagement.TabIndex = 32;
            // 
            // pnlAttendanceUpdate
            // 
            pnlAttendanceUpdate.Controls.Add(dataGridView1);
            pnlAttendanceUpdate.Location = new Point(0, 0);
            pnlAttendanceUpdate.Name = "pnlAttendanceUpdate";
            pnlAttendanceUpdate.Size = new Size(990, 744);
            pnlAttendanceUpdate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(781, 353);
            dataGridView1.TabIndex = 0;
            // 
            // pnlLeaveRequest
            // 
            pnlLeaveRequest.Controls.Add(gridLeaveRequest);
            pnlLeaveRequest.Location = new Point(0, 0);
            pnlLeaveRequest.Name = "pnlLeaveRequest";
            pnlLeaveRequest.Size = new Size(996, 744);
            pnlLeaveRequest.TabIndex = 3;
            // 
            // gridLeaveRequest
            // 
            gridLeaveRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLeaveRequest.Location = new Point(159, 108);
            gridLeaveRequest.Name = "gridLeaveRequest";
            gridLeaveRequest.RowHeadersWidth = 62;
            gridLeaveRequest.RowTemplate.Height = 33;
            gridLeaveRequest.Size = new Size(740, 353);
            gridLeaveRequest.TabIndex = 0;
            // 
            // pnlLeaveBalance
            // 
            pnlLeaveBalance.Controls.Add(gridLeaveBalance);
            pnlLeaveBalance.Location = new Point(0, 3);
            pnlLeaveBalance.Name = "pnlLeaveBalance";
            pnlLeaveBalance.Size = new Size(987, 741);
            pnlLeaveBalance.TabIndex = 3;
            // 
            // gridLeaveBalance
            // 
            gridLeaveBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLeaveBalance.Location = new Point(164, 108);
            gridLeaveBalance.Name = "gridLeaveBalance";
            gridLeaveBalance.RowHeadersWidth = 62;
            gridLeaveBalance.RowTemplate.Height = 33;
            gridLeaveBalance.Size = new Size(740, 353);
            gridLeaveBalance.TabIndex = 2;
            // 
            // pnlApprovedLeave
            // 
            pnlApprovedLeave.Controls.Add(gridAttendanceUpdate);
            pnlApprovedLeave.Location = new Point(0, 0);
            pnlApprovedLeave.Name = "pnlApprovedLeave";
            pnlApprovedLeave.Size = new Size(990, 747);
            pnlApprovedLeave.TabIndex = 3;
            // 
            // gridAttendanceUpdate
            // 
            gridAttendanceUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAttendanceUpdate.Location = new Point(164, 108);
            gridAttendanceUpdate.Name = "gridAttendanceUpdate";
            gridAttendanceUpdate.RowHeadersWidth = 62;
            gridAttendanceUpdate.RowTemplate.Height = 33;
            gridAttendanceUpdate.Size = new Size(740, 353);
            gridAttendanceUpdate.TabIndex = 0;
            // 
            // FormReporting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 750);
            Controls.Add(panel2);
            Controls.Add(pnlLeaveManagement);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormReporting";
            Text = "Form Leave Management";
            panel2.ResumeLayout(false);
            pnlLeaveManagement.ResumeLayout(false);
            pnlAttendanceUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlLeaveRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLeaveRequest).EndInit();
            pnlLeaveBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLeaveBalance).EndInit();
            pnlApprovedLeave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAttendanceUpdate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnAttendanceUpdateView;
        private Button btnApprovedLeaveView;
        private Button btnLeaveBalanceView;
        private Panel panel2;
        private Panel pnlLeaveManagement;
        private Panel pnlLeaveRequest;
        private DataGridView gridLeaveRequest;
        private Panel pnlLeaveBalance;
        private DataGridView gridLeaveBalance;
        private Panel pnlApprovedLeave;
        private DataGridView gridAttendanceUpdate;
        private Button btnLeaveRequestView;
        private Panel pnlAttendanceUpdate;
    }
}