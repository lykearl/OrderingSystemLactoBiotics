namespace LactoBioticsSystem.Products_Management
{
    partial class AddProductStocksForm1cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductStocksForm1cs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuanPerBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddStocks = new System.Windows.Forms.Button();
            this.txtpro_desc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpro_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpro_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpro_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPro_Cat = new System.Windows.Forms.TextBox();
            this.txtpro_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.lblStockOut = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.lblPerQuantity = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.cmbUnitType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQuanPerBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAddStocks);
            this.groupBox1.Controls.Add(this.txtpro_desc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtpro_quantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpro_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpro_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPro_Cat);
            this.groupBox1.Controls.Add(this.txtpro_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 567);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.White;
            this.txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.ForeColor = System.Drawing.Color.Black;
            this.txtBox.Location = new System.Drawing.Point(198, 387);
            this.txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(52, 25);
            this.txtBox.TabIndex = 44;
            this.txtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(208, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Box";
            // 
            // txtQuanPerBox
            // 
            this.txtQuanPerBox.BackColor = System.Drawing.Color.White;
            this.txtQuanPerBox.Enabled = false;
            this.txtQuanPerBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanPerBox.ForeColor = System.Drawing.Color.Black;
            this.txtQuanPerBox.Location = new System.Drawing.Point(52, 387);
            this.txtQuanPerBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuanPerBox.Name = "txtQuanPerBox";
            this.txtQuanPerBox.Size = new System.Drawing.Size(139, 25);
            this.txtQuanPerBox.TabIndex = 45;
            this.txtQuanPerBox.TextChanged += new System.EventHandler(this.TxtQuanPerBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Quantity Per Box";
            // 
            // btnAddStocks
            // 
            this.btnAddStocks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStocks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStocks.ForeColor = System.Drawing.Color.White;
            this.btnAddStocks.Location = new System.Drawing.Point(80, 477);
            this.btnAddStocks.Name = "btnAddStocks";
            this.btnAddStocks.Size = new System.Drawing.Size(137, 37);
            this.btnAddStocks.TabIndex = 6;
            this.btnAddStocks.Text = "Add Product";
            this.btnAddStocks.UseVisualStyleBackColor = false;
            this.btnAddStocks.Click += new System.EventHandler(this.BtnAddStocks_Click);
            // 
            // txtpro_desc
            // 
            this.txtpro_desc.BackColor = System.Drawing.Color.White;
            this.txtpro_desc.Enabled = false;
            this.txtpro_desc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_desc.ForeColor = System.Drawing.Color.Black;
            this.txtpro_desc.Location = new System.Drawing.Point(52, 342);
            this.txtpro_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_desc.Name = "txtpro_desc";
            this.txtpro_desc.Size = new System.Drawing.Size(198, 22);
            this.txtpro_desc.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Description";
            // 
            // txtpro_quantity
            // 
            this.txtpro_quantity.BackColor = System.Drawing.Color.White;
            this.txtpro_quantity.Enabled = false;
            this.txtpro_quantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_quantity.ForeColor = System.Drawing.Color.Black;
            this.txtpro_quantity.Location = new System.Drawing.Point(52, 437);
            this.txtpro_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_quantity.Name = "txtpro_quantity";
            this.txtpro_quantity.Size = new System.Drawing.Size(198, 22);
            this.txtpro_quantity.TabIndex = 4;
            this.txtpro_quantity.TextChanged += new System.EventHandler(this.Txtpro_quantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantity";
            // 
            // txtpro_price
            // 
            this.txtpro_price.BackColor = System.Drawing.Color.White;
            this.txtpro_price.Enabled = false;
            this.txtpro_price.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_price.ForeColor = System.Drawing.Color.Black;
            this.txtpro_price.Location = new System.Drawing.Point(52, 297);
            this.txtpro_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_price.Name = "txtpro_price";
            this.txtpro_price.Size = new System.Drawing.Size(198, 22);
            this.txtpro_price.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Category";
            // 
            // txtpro_name
            // 
            this.txtpro_name.BackColor = System.Drawing.Color.White;
            this.txtpro_name.Enabled = false;
            this.txtpro_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_name.ForeColor = System.Drawing.Color.Black;
            this.txtpro_name.Location = new System.Drawing.Point(52, 204);
            this.txtpro_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_name.Name = "txtpro_name";
            this.txtpro_name.Size = new System.Drawing.Size(198, 22);
            this.txtpro_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name";
            // 
            // txtPro_Cat
            // 
            this.txtPro_Cat.BackColor = System.Drawing.Color.White;
            this.txtPro_Cat.Enabled = false;
            this.txtPro_Cat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro_Cat.ForeColor = System.Drawing.Color.Black;
            this.txtPro_Cat.Location = new System.Drawing.Point(52, 109);
            this.txtPro_Cat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPro_Cat.Name = "txtPro_Cat";
            this.txtPro_Cat.Size = new System.Drawing.Size(198, 22);
            this.txtPro_Cat.TabIndex = 1;
            // 
            // txtpro_code
            // 
            this.txtpro_code.BackColor = System.Drawing.Color.White;
            this.txtpro_code.Enabled = false;
            this.txtpro_code.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_code.ForeColor = System.Drawing.Color.Black;
            this.txtpro_code.Location = new System.Drawing.Point(52, 158);
            this.txtpro_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_code.Name = "txtpro_code";
            this.txtpro_code.Size = new System.Drawing.Size(198, 22);
            this.txtpro_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Code";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(149, 45);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(21, 19);
            this.lblProductID.TabIndex = 25;
            this.lblProductID.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Product ID - ";
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(413, 3);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(29, 32);
            this.picboxPUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPUclose.TabIndex = 41;
            this.picboxPUclose.TabStop = false;
            this.picboxPUclose.Click += new System.EventHandler(this.PicboxPUclose_Click);
            // 
            // lblStockOut
            // 
            this.lblStockOut.AutoSize = true;
            this.lblStockOut.Location = new System.Drawing.Point(340, 281);
            this.lblStockOut.Name = "lblStockOut";
            this.lblStockOut.Size = new System.Drawing.Size(13, 13);
            this.lblStockOut.TabIndex = 42;
            this.lblStockOut.Text = "  ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(325, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 13);
            this.lblQuantity.TabIndex = 43;
            this.lblQuantity.Text = "   ";
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Location = new System.Drawing.Point(325, 357);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(16, 13);
            this.lblBox.TabIndex = 44;
            this.lblBox.Text = "   ";
            this.lblBox.Click += new System.EventHandler(this.LblBox_Click);
            // 
            // lblPerQuantity
            // 
            this.lblPerQuantity.AutoSize = true;
            this.lblPerQuantity.Location = new System.Drawing.Point(325, 336);
            this.lblPerQuantity.Name = "lblPerQuantity";
            this.lblPerQuantity.Size = new System.Drawing.Size(13, 13);
            this.lblPerQuantity.TabIndex = 45;
            this.lblPerQuantity.Text = "  ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(325, 235);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(20, 17);
            this.lblStock.TabIndex = 26;
            this.lblStock.Text = "   ";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Items.AddRange(new object[] {
            "Pieces",
            "Bottles",
            "Sachet"});
            this.cmbUnitType.Location = new System.Drawing.Point(52, 248);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(198, 25);
            this.cmbUnitType.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(62, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Unit Type";
            // 
            // AddProductStocksForm1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(444, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.lblStockOut);
            this.Controls.Add(this.lblPerQuantity);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductStocksForm1cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductStocksForm1cs";
            this.Load += new System.EventHandler(this.AddProductStocksForm1cs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStocks;
        public System.Windows.Forms.TextBox txtpro_desc;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtpro_quantity;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtpro_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtpro_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpro_code;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Label lblStockOut;
        public System.Windows.Forms.TextBox txtPro_Cat;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Label lblPerQuantity;
        public System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtQuanPerBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.Label label10;
    }
}