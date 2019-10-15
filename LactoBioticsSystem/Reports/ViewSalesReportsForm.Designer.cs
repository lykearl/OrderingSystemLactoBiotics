namespace LactoBioticsSystem
{
    partial class ViewSalesReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalesReportsForm));
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.btnPrintSalesReports = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datepicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.datepicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_filter = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.salesreportForm = new LactoBioticsSystem.Reports.SalesReportsForm();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(1006, 2);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(32, 33);
            this.picboxPUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPUclose.TabIndex = 48;
            this.picboxPUclose.TabStop = false;
            this.picboxPUclose.Click += new System.EventHandler(this.PicboxPUclose_Click);
            // 
            // btnPrintSalesReports
            // 
            this.btnPrintSalesReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintSalesReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintSalesReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSalesReports.ForeColor = System.Drawing.Color.White;
            this.btnPrintSalesReports.Location = new System.Drawing.Point(416, 980);
            this.btnPrintSalesReports.Name = "btnPrintSalesReports";
            this.btnPrintSalesReports.Size = new System.Drawing.Size(131, 37);
            this.btnPrintSalesReports.TabIndex = 47;
            this.btnPrintSalesReports.Text = "Print";
            this.btnPrintSalesReports.UseVisualStyleBackColor = false;
            this.btnPrintSalesReports.Click += new System.EventHandler(this.btnPrintSalesReports_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(409, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 40);
            this.label8.TabIndex = 49;
            this.label8.Text = "Sales Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(196, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(673, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // datepicker_startDate
            // 
            this.datepicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_startDate.Location = new System.Drawing.Point(442, 151);
            this.datepicker_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.datepicker_startDate.Name = "datepicker_startDate";
            this.datepicker_startDate.Size = new System.Drawing.Size(151, 20);
            this.datepicker_startDate.TabIndex = 51;
            this.datepicker_startDate.ValueChanged += new System.EventHandler(this.Datepicker_startDate_ValueChanged);
            // 
            // datepicker_enddate
            // 
            this.datepicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_enddate.Location = new System.Drawing.Point(596, 151);
            this.datepicker_enddate.Margin = new System.Windows.Forms.Padding(2);
            this.datepicker_enddate.Name = "datepicker_enddate";
            this.datepicker_enddate.Size = new System.Drawing.Size(151, 20);
            this.datepicker_enddate.TabIndex = 52;
            this.datepicker_enddate.ValueChanged += new System.EventHandler(this.Datepicker_enddate_ValueChanged);
            // 
            // cmbbox_filter
            // 
            this.cmbbox_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_filter.FormattingEnabled = true;
            this.cmbbox_filter.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Custom"});
            this.cmbbox_filter.Location = new System.Drawing.Point(848, 149);
            this.cmbbox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbox_filter.Name = "cmbbox_filter";
            this.cmbbox_filter.Size = new System.Drawing.Size(92, 21);
            this.cmbbox_filter.TabIndex = 53;
            this.cmbbox_filter.SelectedIndexChanged += new System.EventHandler(this.Cmbbox_filter_SelectedIndexChanged);
            this.cmbbox_filter.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(446, 132);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 17);
            this.lblStartDate.TabIndex = 54;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(600, 132);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 17);
            this.lblEndDate.TabIndex = 55;
            this.lblEndDate.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(851, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Report Type:";
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.White;
            this.elementHost1.Location = new System.Drawing.Point(2, 175);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1036, 799);
            this.elementHost1.TabIndex = 56;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.salesreportForm;
            // 
            // ViewSalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 1029);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbbox_filter);
            this.Controls.Add(this.datepicker_enddate);
            this.Controls.Add(this.datepicker_startDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintSalesReports);
            this.Controls.Add(this.elementHost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSalesReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSalesReportsForm";
            this.Load += new System.EventHandler(this.ViewSalesReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Button btnPrintSalesReports;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datepicker_startDate;
        private System.Windows.Forms.DateTimePicker datepicker_enddate;
        private System.Windows.Forms.ComboBox cmbbox_filter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Reports.SalesReportsForm salesreportForm;
        private System.Windows.Forms.Label label1;
    }
}