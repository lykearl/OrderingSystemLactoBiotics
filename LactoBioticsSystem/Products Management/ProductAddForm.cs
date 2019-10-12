using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Products_Management
{
    public partial class ProductAddForm : Form
    {

        public static int catAgriculturalProducts;
        public static int catFoodSuppliments;
        public static int catCosmetics;
        public static int catCape;
        public ProductAddForm()
        {
            InitializeComponent();
            catAgriculturalProducts = (from AgriculturalProducts in db.Products where AgriculturalProducts.ProductCategory == "Agricultural Products" select AgriculturalProducts).Count();
            catFoodSuppliments = (from FoodSuppliments in db.Products where FoodSuppliments.ProductCategory == "Food Suppliments" select FoodSuppliments).Count();
            catCosmetics = (from Cosmetics in db.Products where Cosmetics.ProductCategory == "Cosmetics" select Cosmetics).Count();
            catCape = (from Cape in db.Products where Cape.ProductCategory == "Cape" select Cape).Count();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProCategory.Text == "" || txtpro_code.Text == "" || txtpro_name.Text == "" || txtpro_price.Text == "" || txtpro_desc.Text == "")
                {

                    MessageBox.Show("Please enter product information", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (cmbProCategory.Text == "Agricultural Products")
                    {

                        catAgriculturalProducts++;
                        lblStockOut.Text = "0";
                        db.spAddProducts(txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, decimal.Parse(txtpro_price.Text), int.Parse(txtPro_Quantity.Text), int.Parse(txtQuanPerBox.Text), decimal.Parse(txtBox.Text), txtpro_desc.Text, int.Parse(lblUserID.Text), DateTime.Now);
                        db.spAddInventory(txtpro_code.Text, int.Parse(txtPro_Quantity.Text), int.Parse(txtPro_Quantity.Text), int.Parse(lblStockOut.Text), decimal.Parse(txtBox.Text), DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtPro_Quantity.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.spViewProducts();
                        this.Hide();
                    }
                    else if (cmbProCategory.Text == "Food Suppliments")
                    {
                        catFoodSuppliments++;
                        lblStockOut.Text = "0";
                        db.spAddProducts(txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, decimal.Parse(txtpro_price.Text), int.Parse(txtPro_Quantity.Text), int.Parse(txtQuanPerBox.Text), decimal.Parse(txtBox.Text), txtpro_desc.Text, int.Parse(lblUserID.Text), DateTime.Now);
                        db.spAddInventory(txtpro_code.Text, int.Parse(txtPro_Quantity.Text), int.Parse(txtPro_Quantity.Text), int.Parse(lblStockOut.Text), decimal.Parse(txtBox.Text), DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtPro_Quantity.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.spViewProducts();
                        this.Hide();
                    }
                    else if (cmbProCategory.Text == "Cosmetics")
                    {
                        catCosmetics++;
                        lblStockOut.Text = "0";
                        db.spAddProducts(txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, decimal.Parse(txtpro_price.Text), int.Parse(txtPro_Quantity.Text), int.Parse(txtQuanPerBox.Text), decimal.Parse(txtBox.Text), txtpro_desc.Text, int.Parse(lblUserID.Text), DateTime.Now);
                        db.spAddInventory(txtpro_code.Text, int.Parse(txtPro_Quantity.Text), int.Parse(txtPro_Quantity.Text), int.Parse(lblStockOut.Text), decimal.Parse(txtBox.Text), DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtPro_Quantity.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.spViewProducts();
                        this.Hide();

                    }
                    else if (cmbProCategory.Text == "Cape")
                    {
                        catCape++;
                        lblStockOut.Text = "0";
                        db.spAddProducts(txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, decimal.Parse(txtpro_price.Text), int.Parse(txtPro_Quantity.Text), int.Parse(txtQuanPerBox.Text), decimal.Parse(txtBox.Text), txtpro_desc.Text, int.Parse(lblUserID.Text), DateTime.Now);
                        db.spAddInventory(txtpro_code.Text, int.Parse(txtPro_Quantity.Text), int.Parse(txtPro_Quantity.Text), int.Parse(lblStockOut.Text), decimal.Parse(txtBox.Text), DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtPro_Quantity.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.spViewProducts();
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PicboxPAclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {

        }

        private void CmbProCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
      
        private void CmbProCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProCategory.Text == "Agricultural Products")
            {
                txtpro_code.Text = "AP-" + catAgriculturalProducts.ToString();
            }
            if (cmbProCategory.Text == "Food Suppliments")
            {
                txtpro_code.Text = "FS-" + catFoodSuppliments.ToString();
            }
            if (cmbProCategory.Text == "Cosmetics")
            {
                txtpro_code.Text = "HM-" + catCosmetics.ToString();
            }
            if (cmbProCategory.Text == "Cape")
            {
                txtpro_code.Text = "CP-" + catCape.ToString();
            }

        }

        private void Txtpro_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtPro_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtPro_Quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtQuanPerBox_TextChanged(object sender, EventArgs e)
        {
            double Quantity = 0.0;
            double Box = 0.0;
            try
            {
                if (txtQuanPerBox.Text == "" && txtBox.Text == "")
                {
                    txtPro_Quantity.Text = "";
                }
                else
                {
                    double PerBox = double.Parse(txtQuanPerBox.Text);
                    Box = double.Parse(txtBox.Text);
                    Quantity = PerBox * Box;
                    txtPro_Quantity.Text = Quantity.ToString();
                }
            }
            catch
            { }
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            double Quantity = 0.0;
            double Box = 0.0;
            try
            {
                if (txtQuanPerBox.Text == "" && txtBox.Text == "")
                {
                    txtPro_Quantity.Text = "";
                }
                else
                {
                    double PerBox = double.Parse(txtQuanPerBox.Text);
                    Box = double.Parse(txtBox.Text);
                    Quantity = PerBox * Box;
                    txtPro_Quantity.Text = Quantity.ToString();
                }
            }
            catch
            { }
        }
    }
}
