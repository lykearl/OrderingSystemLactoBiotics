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
    public partial class ViewSalesReportsForm : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        IQueryable<SalesReport> filteredSalesReport;
        class SalesReportViewModel
        {
            public List<SalesReport> SalesReports { get; set; }
            public double Total { get; set; }
            public UserAccount User { get; set; } = ClsLogin.User;

            public DateTime Now {
                get { return DateTime.Now; }
                set { Now = value; }
            }

        }
        public class SalesReports
        {
            List<SalesReport> SalesReportsList { get; set; }

        }
        public ViewSalesReportsForm()
        {
            InitializeComponent();
        }
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewSalesReportsForm_Load(object sender, EventArgs e)
        {
            toggleDatePickerVisibility(false);
            cmbbox_filter.SelectedIndex = 0;
        }

        private void Datepicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            updateSalesReportTable();
        }
        private void Datepicker_enddate_ValueChanged(object sender, EventArgs e)
        {
            updateSalesReportTable();
        }
        private void updateSalesReportTable()
        {
            filteredSalesReport = (from sales in db.SalesReports where sales.Date.Value.Date >= datepicker_startDate.Value.Date && sales.Date.Value.Date <= datepicker_enddate.Value.Date.Date select sales);
            salesreportForm.DataContext = new SalesReportViewModel() { SalesReports = filteredSalesReport.ToList(), Total = (double)filteredSalesReport.Sum(f => f.TotalPrice) };
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            toggleDatePickerVisibility(false);
            switch (cmbbox_filter.Text)
            {
                case "Daily": filteredSalesReport = (from sales in db.SalesReports where sales.Date.Value.Date == DateTime.Now.Date select sales); break;
                case "Weekly": filteredSalesReport = (from sales in db.SalesReports where sales.Date.Value.Date >= DateTime.Now.AddDays(-7) && sales.Date.Value.Date <= DateTime.Now.Date select sales); break;
                case "Monthly": filteredSalesReport = (from sales in db.SalesReports where sales.Date.Value.Date >= DateTime.Now.AddMonths(-1).Date && sales.Date.Value.Date <= DateTime.Now.Date select sales); break;
                case "Custom": toggleDatePickerVisibility(true); break;
            }
            salesreportForm.DataContext = new SalesReportViewModel() { SalesReports = filteredSalesReport.ToList(), Total = (double)filteredSalesReport.Sum(f => f.TotalPrice) };
        }
        private void toggleDatePickerVisibility(bool boolean)
        {
            datepicker_startDate.Visible = boolean;
            datepicker_enddate.Visible = boolean;
            lblStartDate.Visible = boolean;
            lblEndDate.Visible = boolean;
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
        private void DgvSalesInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmbbox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintSalesReports_Click(object sender, EventArgs e)
        {
            Print(salesreportForm.fd_document);
        }
    }
}
