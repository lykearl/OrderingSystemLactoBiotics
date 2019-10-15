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
    public partial class DeliveryReceiptForm : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public class Delivery
        {
            public UserAccount User { get; set; } = ClsLogin.User;
            public List<DeliveryCart> Items { get; set; }
            public string BusinessStyle { get; set; }
        }
        public DeliveryReceiptForm()
        {
            InitializeComponent();

            var x = new Delivery() { Items = (from delivery in db.DeliveryCarts select delivery).ToList() };
            x.BusinessStyle = (from c in db.Customers where c.CustomerId == x.Items[0].CustomerID select c.BusinessStyle).FirstOrDefault();
            deliveryReceiptFormXAML1.DataContext = x;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(deliveryReceiptFormXAML1.fd_documents);
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

        private void DeliveryReceiptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
