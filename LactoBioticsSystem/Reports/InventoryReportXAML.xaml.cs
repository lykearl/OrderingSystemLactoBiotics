using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LactoBioticsSystem.Reports
{
    /// <summary>
    /// Interaction logic for InventoryReportXAML.xaml
    /// </summary>
    public partial class InventoryReportXAML : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public class InventoryReport
        {
            public List<ProductsInventory> Inventories { get; set; }
            public DateTime Now {
                get { return DateTime.Now; }
            }
            public UserAccount User {
                get { return ClsLogin.User; }
            }
        }
        public InventoryReportXAML()
        {
            InitializeComponent();
        }
    }
}
