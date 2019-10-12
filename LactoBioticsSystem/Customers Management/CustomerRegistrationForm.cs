using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Customer_Management
{
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();

        private void CmbuCType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PicboxCRclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || cmbuCType.Text == "" || txtTin.Text == "" || txtBstyle.Text == "")
                {
                    MessageBox.Show("Please input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.spAddCustomer( txtName.Text, txtTin.Text, txtAddress.Text, txtBstyle.Text, txtContact.Text, cmbuCType.Text, int.Parse(lblUserID.Text), DateTime.Now);
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtContact.Text = "";
                    cmbuCType.Text = "";
                    MessageBox.Show("Customer uccessfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm amf = new AdminMainForm();
                    amf.dgvCustomersAcc.DataSource = db.spViewCustomer();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtTin_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"\d{3}\-\d{3}\-\d{3}\-\d{3}");
            if (txtTin.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtTin.Text))
                {
                    MessageBox.Show("Invalid Tin Numer! (Tin Number format should be 000-000-000-000)", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTin.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
