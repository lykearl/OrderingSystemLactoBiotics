﻿namespace LactoBioticsSystem
{
    partial class ViewInventoryReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInventoryReportsForm));
            this.btnPrintInventory = new System.Windows.Forms.Button();
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbox_filter = new System.Windows.Forms.ComboBox();
            this.datepicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.datepicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.inventoryReportXAML1 = new LactoBioticsSystem.Reports.InventoryReportXAML();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInventory.ForeColor = System.Drawing.Color.White;
            this.btnPrintInventory.Location = new System.Drawing.Point(444, 565);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(131, 37);
            this.btnPrintInventory.TabIndex = 42;
            this.btnPrintInventory.Text = "Print";
            this.btnPrintInventory.UseVisualStyleBackColor = false;
            this.btnPrintInventory.Click += new System.EventHandler(this.BtnPrintInventory_Click);
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(992, 2);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(31, 30);
            this.picboxPUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPUclose.TabIndex = 43;
            this.picboxPUclose.TabStop = false;
            this.picboxPUclose.Click += new System.EventHandler(this.PicboxPUclose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(398, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 40);
            this.label8.TabIndex = 44;
            this.label8.Text = "Inventory Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(185, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(673, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
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
            this.cmbbox_filter.Location = new System.Drawing.Point(832, 197);
            this.cmbbox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbox_filter.Name = "cmbbox_filter";
            this.cmbbox_filter.Size = new System.Drawing.Size(92, 21);
            this.cmbbox_filter.TabIndex = 56;
            this.cmbbox_filter.SelectedIndexChanged += new System.EventHandler(this.Cmbbox_filter_SelectedIndexChanged);
            // 
            // datepicker_enddate
            // 
            this.datepicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_enddate.Location = new System.Drawing.Point(581, 199);
            this.datepicker_enddate.Margin = new System.Windows.Forms.Padding(2);
            this.datepicker_enddate.Name = "datepicker_enddate";
            this.datepicker_enddate.Size = new System.Drawing.Size(151, 20);
            this.datepicker_enddate.TabIndex = 55;
            // 
            // datepicker_startDate
            // 
            this.datepicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_startDate.Location = new System.Drawing.Point(427, 199);
            this.datepicker_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.datepicker_startDate.Name = "datepicker_startDate";
            this.datepicker_startDate.Size = new System.Drawing.Size(151, 20);
            this.datepicker_startDate.TabIndex = 54;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(-2, 231);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1025, 328);
            this.elementHost1.TabIndex = 57;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.inventoryReportXAML1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblEndDate.Location = new System.Drawing.Point(585, 180);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 17);
            this.lblEndDate.TabIndex = 59;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblStartDate.Location = new System.Drawing.Point(431, 180);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 17);
            this.lblStartDate.TabIndex = 58;
            this.lblStartDate.Text = "Start Date:";
            // 
            // ViewInventoryReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1025, 621);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.cmbbox_filter);
            this.Controls.Add(this.datepicker_enddate);
            this.Controls.Add(this.datepicker_startDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewInventoryReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInventoryReportsForm";
            this.Load += new System.EventHandler(this.ViewInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrintInventory;
        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbox_filter;
        private System.Windows.Forms.DateTimePicker datepicker_enddate;
        private System.Windows.Forms.DateTimePicker datepicker_startDate;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Reports.InventoryReportXAML inventoryReportXAML1;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}