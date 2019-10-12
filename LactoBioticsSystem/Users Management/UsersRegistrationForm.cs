using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Users_Management
{
    public partial class UsersRegistrationForm : Form
    {
        public UsersRegistrationForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuname.Text.Trim() == "" || txtpass.Text.Trim() == "" ||
             txtlname.Text.Trim() == "" || txtfname.Text.Trim() == "" || txtemail.Text.Trim() == "" ||
            cmbQuest.Text.Trim() == "" || txtans.Text.Trim() == "")
            {
                MessageBox.Show("Please complete the fields!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                    AdminMainForm amf = new AdminMainForm();
                    amf.txtusertype.Text = "Staff";
                    amf.txtuserstatus.Text = "Active";
                    db.spAddUser(txtuname.Text, txtpass.Text, cmbUserType.Text, txtfname.Text, txtlname.Text,
                    txtemail.Text, amf.txtuserstatus.Text, cmbQuest.Text, txtans.Text, DateTime.Now);
                    txtuname.Text = "";
                    txtpass.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    txtemail.Text = "";
                    cmbQuest.Text = "";
                    txtans.Text = "";
                    MessageBox.Show("User successfully Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amf.pnlAdminMenu.Hide();
                    this.Hide();
                    amf.dgvUsersAcc.DataSource = db.spViewUser();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void PURclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmbutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmbstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbQuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Txtemail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if(txtemail.Text.Length > 0)
            {
                if(!rEmail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("Invalid Email Address!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtemail.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
