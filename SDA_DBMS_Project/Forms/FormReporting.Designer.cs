﻿namespace SDA_DBMS_Project.Forms
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
            this.btnClockInOutView = new System.Windows.Forms.Button();
            this.btnBreakDurationView = new System.Windows.Forms.Button();
            this.btnOvertimeHoursView = new System.Windows.Forms.Button();
            this.pnlClockInOut = new System.Windows.Forms.Panel();
            this.gridClockView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBreakView = new System.Windows.Forms.Panel();
            this.gridBreakView = new System.Windows.Forms.DataGridView();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.gridOvertime = new System.Windows.Forms.DataGridView();
            this.pnlClockInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClockView)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlBreakView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBreakView)).BeginInit();
            this.pnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOvertime)).BeginInit();
            this.SuspendLayout();
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
            this.btnClockInOutView.Location = new System.Drawing.Point(22, 484);
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
            this.btnBreakDurationView.Location = new System.Drawing.Point(22, 599);
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
            this.btnOvertimeHoursView.Location = new System.Drawing.Point(22, 724);
            this.btnOvertimeHoursView.Name = "btnOvertimeHoursView";
            this.btnOvertimeHoursView.Size = new System.Drawing.Size(216, 71);
            this.btnOvertimeHoursView.TabIndex = 26;
            this.btnOvertimeHoursView.Text = "OvertimeHoursView";
            this.btnOvertimeHoursView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOvertimeHoursView.UseVisualStyleBackColor = true;
            // 
            // pnlClockInOut
            // 
            this.pnlClockInOut.Controls.Add(this.gridClockView);
            this.pnlClockInOut.Location = new System.Drawing.Point(374, 138);
            this.pnlClockInOut.Name = "pnlClockInOut";
            this.pnlClockInOut.Size = new System.Drawing.Size(521, 314);
            this.pnlClockInOut.TabIndex = 34;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnClockInOutView);
            this.panel2.Controls.Add(this.btnBreakDurationView);
            this.panel2.Controls.Add(this.btnOvertimeHoursView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 450);
            this.panel2.TabIndex = 33;
            // 
            // pnlBreakView
            // 
            this.pnlBreakView.Controls.Add(this.gridBreakView);
            this.pnlBreakView.Location = new System.Drawing.Point(374, 132);
            this.pnlBreakView.Name = "pnlBreakView";
            this.pnlBreakView.Size = new System.Drawing.Size(521, 320);
            this.pnlBreakView.TabIndex = 31;
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
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.gridOvertime);
            this.pnlOverview.Location = new System.Drawing.Point(374, 132);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(521, 317);
            this.pnlOverview.TabIndex = 32;
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
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.pnlClockInOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBreakView);
            this.Controls.Add(this.pnlOverview);
            this.Name = "FormReporting";
            this.Text = "FormReporting";
            this.pnlClockInOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClockView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlBreakView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBreakView)).EndInit();
            this.pnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOvertime)).EndInit();
            this.ResumeLayout(false);

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
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnClockInOutView;
        private Button btnBreakDurationView;
        private Button btnOvertimeHoursView;
        private Panel pnlClockInOut;
        private DataGridView gridClockView;
        private Panel panel2;
        private Panel pnlBreakView;
        private DataGridView gridBreakView;
        private Panel pnlOverview;
        private DataGridView gridOvertime;
    }
}