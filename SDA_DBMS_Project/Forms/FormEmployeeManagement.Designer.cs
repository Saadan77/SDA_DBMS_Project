namespace SDA_DBMS_Project.Forms
{
    partial class FormEmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeManagement));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClockInOutView = new System.Windows.Forms.Button();
            this.btnBreakDurationView = new System.Windows.Forms.Button();
            this.btnOvertimeHoursView = new System.Windows.Forms.Button();
            this.pnEmployeeView = new System.Windows.Forms.Panel();
            this.gridEmployeeView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.pnEmployeeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnClockInOutView);
            this.panel2.Controls.Add(this.btnBreakDurationView);
            this.panel2.Controls.Add(this.btnOvertimeHoursView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 687);
            this.panel2.TabIndex = 30;
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
            this.button1.Location = new System.Drawing.Point(3, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 71);
            this.button1.TabIndex = 27;
            this.button1.Text = "Employee Data";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClockInOutView
            // 
            this.btnClockInOutView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClockInOutView.FlatAppearance.BorderSize = 0;
            this.btnClockInOutView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockInOutView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClockInOutView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClockInOutView.Image = ((System.Drawing.Image)(resources.GetObject("btnClockInOutView.Image")));
            this.btnClockInOutView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClockInOutView.Location = new System.Drawing.Point(22, 847);
            this.btnClockInOutView.Name = "btnClockInOutView";
            this.btnClockInOutView.Size = new System.Drawing.Size(216, 71);
            this.btnClockInOutView.TabIndex = 24;
            this.btnClockInOutView.Text = "   ClockInOutView";
            this.btnClockInOutView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClockInOutView.UseVisualStyleBackColor = true;
            // 
            // btnBreakDurationView
            // 
            this.btnBreakDurationView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreakDurationView.FlatAppearance.BorderSize = 0;
            this.btnBreakDurationView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakDurationView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBreakDurationView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBreakDurationView.Image = ((System.Drawing.Image)(resources.GetObject("btnBreakDurationView.Image")));
            this.btnBreakDurationView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreakDurationView.Location = new System.Drawing.Point(22, 962);
            this.btnBreakDurationView.Name = "btnBreakDurationView";
            this.btnBreakDurationView.Size = new System.Drawing.Size(216, 71);
            this.btnBreakDurationView.TabIndex = 25;
            this.btnBreakDurationView.Text = "BreakDurationView";
            this.btnBreakDurationView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBreakDurationView.UseVisualStyleBackColor = true;
            // 
            // btnOvertimeHoursView
            // 
            this.btnOvertimeHoursView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOvertimeHoursView.FlatAppearance.BorderSize = 0;
            this.btnOvertimeHoursView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOvertimeHoursView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOvertimeHoursView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOvertimeHoursView.Image = ((System.Drawing.Image)(resources.GetObject("btnOvertimeHoursView.Image")));
            this.btnOvertimeHoursView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOvertimeHoursView.Location = new System.Drawing.Point(22, 1087);
            this.btnOvertimeHoursView.Name = "btnOvertimeHoursView";
            this.btnOvertimeHoursView.Size = new System.Drawing.Size(216, 71);
            this.btnOvertimeHoursView.TabIndex = 26;
            this.btnOvertimeHoursView.Text = "OvertimeHoursView";
            this.btnOvertimeHoursView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOvertimeHoursView.UseVisualStyleBackColor = true;
            // 
            // pnEmployeeView
            // 
            this.pnEmployeeView.Controls.Add(this.gridEmployeeView);
            this.pnEmployeeView.Location = new System.Drawing.Point(334, 149);
            this.pnEmployeeView.Name = "pnEmployeeView";
            this.pnEmployeeView.Size = new System.Drawing.Size(521, 314);
            this.pnEmployeeView.TabIndex = 33;
            // 
            // gridEmployeeView
            // 
            this.gridEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployeeView.Location = new System.Drawing.Point(3, 3);
            this.gridEmployeeView.Name = "gridEmployeeView";
            this.gridEmployeeView.RowTemplate.Height = 25;
            this.gridEmployeeView.Size = new System.Drawing.Size(518, 308);
            this.gridEmployeeView.TabIndex = 0;
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.pnEmployeeView);
            this.Controls.Add(this.panel2);
            this.Name = "FormEmployeeManagement";
            this.Text = "FormEmployeeManagement";
            this.panel2.ResumeLayout(false);
            this.pnEmployeeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button btnClockInOutView;
        private Button btnBreakDurationView;
        private Button btnOvertimeHoursView;
        private Button button1;
        private Panel pnEmployeeView;
        private DataGridView gridEmployeeView;
    }
}