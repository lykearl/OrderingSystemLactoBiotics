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
    public partial class UsersUpdateForm : Form
    {
        public UsersUpdateForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
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

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblUser_ID.Text.Trim() == "" || txtuname.Text.Trim() == "" || txtpass.Text.Trim() == "" || cmbUsertype.Text.Trim() == "" ||
                txtlname.Text.Trim() == "" || txtfname.Text.Trim() == "" || txtemail.Text.Trim() == "" || cmbstatus.Text == "" ||
                cmbQuest.Text.Trim() == "" || txtans.Text.Trim() == "")
            {
                MessageBox.Show("Please input fields to update user account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {              
                    AdminMainForm amf = new AdminMainForm();
                    db.spUpdateUser(int.Parse(lblUser_ID.Text), txtuname.Text, txtpass.Text, cmbUsertype.Text, txtfname.Text, txtlname.Text,
                   txtemail.Text, cmbstatus.Text, cmbQuest.Text, txtans.Text, DateTime.Now);
                    lblUser_ID.Text = "";
                    txtuname.Text = "";
                    txtpass.Text = "";
                    cmbUsertype.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    txtemail.Text = "";
                    amf.txtuserstatus.Text = "";
                    cmbQuest.Text = "";
                    txtans.Text = "";
                    MessageBox.Show("User successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    amf.dgvUsersAcc.DataSource = db.spViewUser();
                    this.Hide();
                }            
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void PUClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtemail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtemail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("Invalid Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
