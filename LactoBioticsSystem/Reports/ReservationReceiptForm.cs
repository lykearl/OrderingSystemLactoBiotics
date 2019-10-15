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
    public partial class ReservationReceiptForm : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public class Reservation
        {
            public UserAccount User { get; set; } = ClsLogin.User;
            public List<ReservationCart> Items { get; set; }
            public string BusinessStyle { get; set; }
        }
        public ReservationReceiptForm()
        {
            InitializeComponent();

            var x = new Reservation() { Items = (from reservation in db.ReservationCarts select reservation).ToList() };
            x.BusinessStyle = (from c in db.Customers where c.CustomerId == x.Items[0].CustomerID select c.BusinessStyle).FirstOrDefault();
            reservationReceiptFormXaml1.DataContext = x;
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
        private void ReservationReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(reservationReceiptFormXaml1.fd_documents);
        }
    }
}
