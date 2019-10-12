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
    public partial class ViewProductsForm : Form
    {
        public ViewProductsForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            dgvStocks.DataSource = db.spViewProducts();
            RowsColor();
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            RowsColor();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void TxtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            dgvStocks.DataSource = db.spSearchProducts(txtSearchProducts.Text);
            RowsColor();
        }
        public void RowsColor()
        {
            for(int  i = 0; i < dgvStocks.Rows.Count; i ++)
            {
                int val = Int32.Parse(dgvStocks.Rows[i].Cells[6].Value.ToString());
                if (val <= 5)
                {
                    dgvStocks.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
