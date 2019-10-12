using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LactoBioticsSystem
{
    public partial class ViewInventoryReportsForm : Form
    {
        IQueryable<ProductsInventory> filteredInventories;
        DatabaseDataContext db = new DatabaseDataContext();
        public class InventoryReport
        {
            public List<ProductsInventory> FoodSupplement { get; set; }
            public List<ProductsInventory> AgriProducts { get; set; }
            public List<ProductsInventory> Cosmetics { get; set; }
            public List<ProductsInventory> CAPE { get; set; }
            public DateTime Now {
                get { return DateTime.Now; }
            }
            public UserAccount User {
                get { return ClsLogin.User; }
            }
        }
        public ViewInventoryReportsForm()
        {
            InitializeComponent();
        }
        private void ViewInventoryForm_Load(object sender, EventArgs e)
        {

            toggleDatePickerVisibility(false);
            var foodsupplements = (from fs in db.ProductsInventories where fs.Product.ProductCategory == "Food Suppliments" select fs).ToList();
            var agriproducts = (from fs in db.ProductsInventories where fs.Product.ProductCategory == "Agricultural Products" select fs).ToList();
            var cosmetics = (from fs in db.ProductsInventories where fs.Product.ProductCategory == "Cosmetics" select fs).ToList();
            var cape = (from fs in db.ProductsInventories where fs.Product.ProductCategory == "Cape" select fs).ToList();
            inventoryReportXAML1.DataContext = new InventoryReport { AgriProducts = agriproducts, FoodSupplement = foodsupplements, Cosmetics = cosmetics, CAPE = cape };
        }

        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrintInventory_Click(object sender, EventArgs e)
        {
            Print(inventoryReportXAML1.fd_InventoryReport);
        }
        public void Print(FlowDocument fd)
        {
            var pd = new System.Windows.Controls.PrintDialog();
            if (pd.ShowDialog().Value)
            {
                IDocumentPaginatorSource document = fd as IDocumentPaginatorSource;
                try
                {
                    pd.PrintDocument(document.DocumentPaginator, "Printing FlowDocument.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void toggleDatePickerVisibility(bool boolean)
        {
            datepicker_startDate.Visible = boolean;
            datepicker_enddate.Visible = boolean;
            lblStartDate.Visible = boolean;
            lblEndDate.Visible = boolean;
        }

        private void Cmbbox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleDatePickerVisibility(false);
            switch (cmbbox_filter.Text)
            {
                case "Daily": filteredInventories = (from inv in db.ProductsInventories where inv.Date.Value.Date == DateTime.Now.Date select inv); break;
                case "Weekly": filteredInventories = (from inv in db.ProductsInventories where inv.Date.Value.Date >= DateTime.Now.AddDays(-7) && inv.Date.Value.Date <= DateTime.Now.Date select inv); break;
                case "Monthly": filteredInventories = (from inv in db.ProductsInventories where inv.Date.Value.Date >= DateTime.Now.AddMonths(-1).Date && inv.Date.Value.Date <= DateTime.Now.Date select inv); break;
                case "Custom": toggleDatePickerVisibility(true); break;
            }

            var foodsupplements = (from fs in filteredInventories where fs.Product.ProductCategory == "Food Suppliments" select fs).ToList();
            var agriproducts = (from fs in filteredInventories where fs.Product.ProductCategory == "Agricultural Products" select fs).ToList();
            var cosmetics = (from fs in filteredInventories where fs.Product.ProductCategory == "Cosmetics" select fs).ToList();
            var cape = (from fs in filteredInventories where fs.Product.ProductCategory == "Cape" select fs).ToList();
            inventoryReportXAML1.DataContext = new InventoryReport { AgriProducts = agriproducts, FoodSupplement = foodsupplements, Cosmetics = cosmetics, CAPE = cape };
        }
    }
}
