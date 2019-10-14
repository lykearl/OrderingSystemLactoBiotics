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

namespace LactoBioticsSystem.Reports
{
    public partial class SalesInvoiceForm : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public class SalesInvoice
        {
            public UserAccount User { get; set; } = ClsLogin.User;
            public List<AddToCart> Items { get; set; }
            public string BusinessStyle { get; set; }
        }
        public SalesInvoiceForm()
        {
            InitializeComponent();

            var x = new SalesInvoice() { Items = (from addToCarts in db.AddToCarts select addToCarts).ToList() };
            x.BusinessStyle = (from c in db.Customers where c.CustomerId == x.Items[0].CustomerID select c.BusinessStyle).FirstOrDefault();
            salesInvoiceFormXAML1.DataContext = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(salesInvoiceFormXAML1.fd_documents);
        }
        private void Print(FlowDocument fd)
        {
            var pd = new System.Windows.Controls.PrintDialog();
            if (pd.ShowDialog().Value)
            {
                IDocumentPaginatorSource document = fd as IDocumentPaginatorSource;
                try
                {
                    pd.PrintDocument(document.DocumentPaginator, "Printing FlowDocument.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
