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
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProductID.Text == "" || txtpro_code.Text == "" || txtpro_name.Text == "" || txtProCat.Text == "" || txtpro_price.Text == "" || txtQuanPerBox.Text == "" || txtBox.Text == "" || txtpro_quantity.Text == "" || txtpro_desc.Text == "")
            {
                MessageBox.Show("Please enter product information", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                    db.spUpdateProducts(int.Parse(lblProductID.Text), txtpro_code.Text, txtpro_name.Text, txtProCat.Text, int.Parse(txtpro_price.Text), int.Parse(txtpro_quantity.Text), int.Parse(txtQuanPerBox.Text), int.Parse(txtBox.Text), txtpro_desc.Text, DateTime.Now);
                    lblProductID.Text = "";
                    txtpro_code.Text = "";
                    txtpro_name.Text = "";
                    txtProCat.Text = "";
                    txtpro_price.Text = "";
                    txtpro_desc.Text = "";
                    MessageBox.Show("Product successfully Updated!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm amf = new AdminMainForm();
                    amf.dgvProducts.DataSource = db.spViewProducts();
                    this.Hide();
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Txtpro_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtQuanPerBox_TextChanged(object sender, EventArgs e)
        {
            double Quantity = 0.0;
            double Box = 0.0;
            try
            {
                double PerBox = double.Parse(txtQuanPerBox.Text);
                Box = double.Parse(txtBox.Text);
                Quantity = PerBox * Box;
                txtpro_quantity.Text = Quantity.ToString();
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
                    txtpro_quantity.Text = "";
                }
                else
                {
                    double PerBox = double.Parse(txtQuanPerBox.Text);
                    Box = double.Parse(txtBox.Text);
                    Quantity = PerBox * Box;
                    txtpro_quantity.Text = Quantity.ToString();
                }
            }
            catch
            {
            } 
            
        }
    }
}