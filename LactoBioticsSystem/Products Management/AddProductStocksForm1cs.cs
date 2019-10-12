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
    public partial class AddProductStocksForm1cs : Form
    {
        public AddProductStocksForm1cs()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();

        private void BtnAddStocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProductID.Text == "" || txtpro_code.Text == "" || txtpro_name.Text == "" || txtPro_Cat.Text == "" || txtpro_price.Text == "" || txtpro_quantity.Text == "")
                {
                    MessageBox.Show("Please enter product information", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    int Stock = int.Parse(lblStock.Text);
                    int Pquantity = int.Parse(txtpro_quantity.Text);
                    int StocksAdded = Stock + Pquantity;
                    lblStockOut.Text = "0";
                    db.spUpdateStocks(txtpro_code.Text, int.Parse(txtpro_quantity.Text), decimal.Parse(txtBox.Text));
                    db.spAddInventory(txtpro_code.Text, StocksAdded, int.Parse(txtpro_quantity.Text), int.Parse(lblStockOut.Text), decimal.Parse(txtBox.Text), DateTime.Now);
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

        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductStocksForm1cs_Load(object sender, EventArgs e)
        {

        }

        private void LblBox_Click(object sender, EventArgs e)
        {
          
        }

        private void Txtpro_quantity_TextChanged(object sender, EventArgs e)
        {
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
            { }
        }

        private void TxtQuanPerBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
