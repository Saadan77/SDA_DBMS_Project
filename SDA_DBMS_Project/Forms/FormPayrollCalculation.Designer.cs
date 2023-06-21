namespace SDA_DBMS_Project.Forms
{
    partial class FormPayrollCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayrollCalculation));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlEmployeeCalc = new Panel();
            pnlPayrollReport = new Panel();
            gridPayrollReport = new DataGridView();
            pnlPayslip = new Panel();
            gridPayslip = new DataGridView();
            panel2 = new Panel();
            btnPayslip = new Button();
            btnPayrollReport = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelTitleBar = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            btnLeave = new Button();
            btnPcalculation = new Button();
            btnPprocessing = new Button();
            btnAttendance = new Button();
            btnReporting = new Button();
            btnManagement = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pnlEmployeeCalc.SuspendLayout();
            pnlPayrollReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayrollReport).BeginInit();
            pnlPayslip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayslip).BeginInit();
            panel2.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(793, 772);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(149, 73);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(990, 772);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(147, 73);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1183, 772);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(167, 73);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlEmployeeCalc
            // 
            pnlEmployeeCalc.Controls.Add(pnlPayrollReport);
            pnlEmployeeCalc.Controls.Add(pnlPayslip);
            pnlEmployeeCalc.Controls.Add(panel2);
            pnlEmployeeCalc.Location = new Point(314, 133);
            pnlEmployeeCalc.Margin = new Padding(4, 5, 4, 5);
            pnlEmployeeCalc.Name = "pnlEmployeeCalc";
            pnlEmployeeCalc.Size = new Size(1133, 802);
            pnlEmployeeCalc.TabIndex = 17;
            // 
            // pnlPayrollReport
            // 
            pnlPayrollReport.Controls.Add(gridPayrollReport);
            pnlPayrollReport.Location = new Point(264, 0);
            pnlPayrollReport.Name = "pnlPayrollReport";
            pnlPayrollReport.Size = new Size(869, 798);
            pnlPayrollReport.TabIndex = 3;
            // 
            // gridPayrollReport
            // 
            gridPayrollReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPayrollReport.Location = new Point(179, 183);
            gridPayrollReport.Name = "gridPayrollReport";
            gridPayrollReport.RowHeadersWidth = 62;
            gridPayrollReport.RowTemplate.Height = 33;
            gridPayrollReport.Size = new Size(593, 225);
            gridPayrollReport.TabIndex = 2;
            // 
            // pnlPayslip
            // 
            pnlPayslip.Controls.Add(gridPayslip);
            pnlPayslip.Location = new Point(263, 0);
            pnlPayslip.Name = "pnlPayslip";
            pnlPayslip.Size = new Size(870, 797);
            pnlPayslip.TabIndex = 3;
            // 
            // gridPayslip
            // 
            gridPayslip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPayslip.Location = new Point(179, 183);
            gridPayslip.Name = "gridPayslip";
            gridPayslip.RowHeadersWidth = 62;
            gridPayslip.RowTemplate.Height = 33;
            gridPayslip.Size = new Size(623, 233);
            gridPayslip.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(btnPayslip);
            panel2.Controls.Add(btnPayrollReport);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 802);
            panel2.TabIndex = 1;
            // 
            // btnPayslip
            // 
            btnPayslip.FlatAppearance.BorderSize = 0;
            btnPayslip.FlatStyle = FlatStyle.Flat;
            btnPayslip.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayslip.ForeColor = Color.FromArgb(0, 126, 249);
            btnPayslip.Image = (Image)resources.GetObject("btnPayslip.Image");
            btnPayslip.Location = new Point(4, 78);
            btnPayslip.Margin = new Padding(4, 5, 4, 5);
            btnPayslip.Name = "btnPayslip";
            btnPayslip.Size = new Size(266, 83);
            btnPayslip.TabIndex = 4;
            btnPayslip.Text = "Pay Slip";
            btnPayslip.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayslip.UseVisualStyleBackColor = true;
            // 
            // btnPayrollReport
            // 
            btnPayrollReport.FlatAppearance.BorderSize = 0;
            btnPayrollReport.FlatStyle = FlatStyle.Flat;
            btnPayrollReport.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayrollReport.ForeColor = Color.FromArgb(0, 126, 249);
            btnPayrollReport.Image = (Image)resources.GetObject("btnPayrollReport.Image");
            btnPayrollReport.Location = new Point(4, 0);
            btnPayrollReport.Margin = new Padding(4, 5, 4, 5);
            btnPayrollReport.Name = "btnPayrollReport";
            btnPayrollReport.Size = new Size(257, 83);
            btnPayrollReport.TabIndex = 3;
            btnPayrollReport.Text = "Payroll Report";
            btnPayrollReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayrollReport.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1873, 0);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(43, 50);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1906, 0);
            btnMaximize.Margin = new Padding(4, 5, 4, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(43, 50);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1941, 0);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 50);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Margin = new Padding(4, 5, 4, 5);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(107, 133);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(263, 45);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(607, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EMPLOYEE PAYROLL CALCULATION";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 30, 54);
            panelTitleBar.Controls.Add(panel4);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(314, 0);
            panelTitleBar.Margin = new Padding(4, 5, 4, 5);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1056, 133);
            panelTitleBar.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Location = new Point(264, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 3;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Gainsboro;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 733);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(314, 100);
            button4.TabIndex = 7;
            button4.Text = "   Employees";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnLeave
            // 
            btnLeave.Dock = DockStyle.Top;
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.ForeColor = Color.Gainsboro;
            btnLeave.Image = (Image)resources.GetObject("btnLeave.Image");
            btnLeave.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeave.Location = new Point(0, 633);
            btnLeave.Margin = new Padding(4, 5, 4, 5);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(314, 100);
            btnLeave.TabIndex = 6;
            btnLeave.Text = "   Leave Management";
            btnLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeave.UseVisualStyleBackColor = true;
            // 
            // btnPcalculation
            // 
            btnPcalculation.Dock = DockStyle.Top;
            btnPcalculation.FlatAppearance.BorderSize = 0;
            btnPcalculation.FlatStyle = FlatStyle.Flat;
            btnPcalculation.ForeColor = Color.Gainsboro;
            btnPcalculation.Image = (Image)resources.GetObject("btnPcalculation.Image");
            btnPcalculation.ImageAlign = ContentAlignment.MiddleLeft;
            btnPcalculation.Location = new Point(0, 533);
            btnPcalculation.Margin = new Padding(4, 5, 4, 5);
            btnPcalculation.Name = "btnPcalculation";
            btnPcalculation.Size = new Size(314, 100);
            btnPcalculation.TabIndex = 5;
            btnPcalculation.Text = "   Payroll Calculation";
            btnPcalculation.TextAlign = ContentAlignment.MiddleLeft;
            btnPcalculation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPcalculation.UseVisualStyleBackColor = true;
            // 
            // btnPprocessing
            // 
            btnPprocessing.Dock = DockStyle.Top;
            btnPprocessing.FlatAppearance.BorderSize = 0;
            btnPprocessing.FlatStyle = FlatStyle.Flat;
            btnPprocessing.ForeColor = Color.Gainsboro;
            btnPprocessing.Image = (Image)resources.GetObject("btnPprocessing.Image");
            btnPprocessing.ImageAlign = ContentAlignment.MiddleLeft;
            btnPprocessing.Location = new Point(0, 433);
            btnPprocessing.Margin = new Padding(4, 5, 4, 5);
            btnPprocessing.Name = "btnPprocessing";
            btnPprocessing.Size = new Size(314, 100);
            btnPprocessing.TabIndex = 4;
            btnPprocessing.Text = "   Payroll Processing";
            btnPprocessing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPprocessing.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.Gainsboro;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(0, 333);
            btnAttendance.Margin = new Padding(4, 5, 4, 5);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(314, 100);
            btnAttendance.TabIndex = 3;
            btnAttendance.Text = "   Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnReporting
            // 
            btnReporting.Dock = DockStyle.Top;
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.ForeColor = Color.Gainsboro;
            btnReporting.Image = (Image)resources.GetObject("btnReporting.Image");
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 233);
            btnReporting.Margin = new Padding(4, 5, 4, 5);
            btnReporting.Name = "btnReporting";
            btnReporting.Size = new Size(314, 100);
            btnReporting.TabIndex = 2;
            btnReporting.Text = "   Reporting and Analytics";
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            // 
            // btnManagement
            // 
            btnManagement.Dock = DockStyle.Top;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.ForeColor = Color.Gainsboro;
            btnManagement.Image = (Image)resources.GetObject("btnManagement.Image");
            btnManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnManagement.Location = new Point(0, 133);
            btnManagement.Margin = new Padding(4, 5, 4, 5);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(314, 100);
            btnManagement.TabIndex = 1;
            btnManagement.Text = "   Employee Management";
            btnManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManagement.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(314, 133);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnLeave);
            panel1.Controls.Add(btnPcalculation);
            panel1.Controls.Add(btnPprocessing);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(btnReporting);
            panel1.Controls.Add(btnManagement);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 748);
            panel1.TabIndex = 15;
            // 
            // FormPayrollCalculation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 748);
            Controls.Add(pnlEmployeeCalc);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPayrollCalculation";
            Text = "FormPayrollCalculation";
            pnlEmployeeCalc.ResumeLayout(false);
            pnlPayrollReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPayrollReport).EndInit();
            pnlPayslip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPayslip).EndInit();
            panel2.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlEmployeeCalc;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnCloseChildForm;
        private Label lblTitle;
        private Panel panelTitleBar;
        private Button button4;
        private Button btnLeave;
        private Button btnPcalculation;
        private Button btnPprocessing;
        private Button btnAttendance;
        private Button btnReporting;
        private Button btnManagement;
        private Panel panelLogo;
        private Panel panel1;
        private Panel panel2;
        private Button btnPayslip;
        private Button btnScholarship;
        private Button btnLaptopScheme;
        private Button btnPayrollReport;
        private Panel panel4;
        private DataGridView gridPayrollReport;
        private Panel pnlPayrollReport;
        private Panel pnlPayslip;
        private DataGridView gridPayslip;
        private PictureBox pictureBox1;
    }
}