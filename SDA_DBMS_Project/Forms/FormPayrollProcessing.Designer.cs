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
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.gridOvertime = new System.Windows.Forms.DataGridView();
            this.pnlBreakView = new System.Windows.Forms.Panel();
            this.gridBreakView = new System.Windows.Forms.DataGridView();
            this.pnlClockInOut = new System.Windows.Forms.Panel();
            this.gridClockView = new System.Windows.Forms.DataGridView();
            this.btnPayrollExpenseView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPayrollExpenseView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 687);
            this.panel2.TabIndex = 30;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.gridOvertime);
            this.pnlOverview.Location = new System.Drawing.Point(372, 156);
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
            this.pnlBreakView.Location = new System.Drawing.Point(372, 156);
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
            this.pnlClockInOut.Location = new System.Drawing.Point(372, 162);
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
            // btnPayrollExpenseView
            // 
            this.btnPayrollExpenseView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayrollExpenseView.FlatAppearance.BorderSize = 0;
            this.btnPayrollExpenseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayrollExpenseView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayrollExpenseView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayrollExpenseView.Image = ((System.Drawing.Image)(resources.GetObject("btnPayrollExpenseView.Image")));
            this.btnPayrollExpenseView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayrollExpenseView.Location = new System.Drawing.Point(0, 156);
            this.btnPayrollExpenseView.Name = "btnPayrollExpenseView";
            this.btnPayrollExpenseView.Size = new System.Drawing.Size(216, 71);
            this.btnPayrollExpenseView.TabIndex = 25;
            this.btnPayrollExpenseView.Text = "   PayrollExpenseView";
            this.btnPayrollExpenseView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayrollExpenseView.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(0, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 71);
            this.button1.TabIndex = 26;
            this.button1.Text = "   ClockInOutView";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 71);
            this.button2.TabIndex = 27;
            this.button2.Text = "   ClockInOutView";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
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
        private Button button2;
        private Button button1;
        private Button btnPayrollExpenseView;
    }
}