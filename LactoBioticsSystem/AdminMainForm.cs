using LactoBioticsSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        int IndexRow;
      
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.spViewUser();
            dgvCustomersAcc.DataSource = db.spViewCustomer();
            dgvProducts.DataSource = db.spViewProducts();
            dgvCustDelivery.DataSource = db.spSelectDelivery();
            dgvCustReservation.DataSource = db.spSelectReservation();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            txtpro_quantity.Enabled = false;
            btnSelectCust.Enabled = false;
            btnSelectPro.Enabled = false;
        }

        private void BtnCostOrder_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnUserReg_Click(object sender, EventArgs e)
        {
            pnlUser_reg.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCustReg_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlHeader.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;;
        }

        private void BtnProReg_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlProReg.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            pnlReports.Show();
            pnlHeader.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            pnlAdminMenu.Show();
            pnlSystemTitle.Show();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlHeader.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCOrder_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnUsersReg_Click(object sender, EventArgs e)
        {
            pnlUser_reg.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCustRegs_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlHeader.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnProdReg_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlProReg.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            pnlReports.Show();
            pnlHeader.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void PicboxAdClose_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Activate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Activate this User Account?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtuserstatus.Text = "Active";
                        db.spUpdateUser(int.Parse(labelUserID.Text), txtusername.Text, txtuserpass.Text, txtusertype.Text, txtlastname.Text,
                         txtfirstname.Text, txtemail.Text, txtuserstatus.Text, txtsecretQ.Text, txtsecretA.Text, DateTime.Now);
                        labelUserID.Text = "";
                        txtusername.Text = "";
                        txtuserpass.Text = "";
                        txtusertype.Text = "";
                        txtlastname.Text = "";
                        txtfirstname.Text = "";
                        txtemail.Text = "";
                        txtuserstatus.Text = "";
                        txtsecretQ.Text = "";
                        txtsecretA.Text = "";
                        dgvUsersAcc.DataSource = db.spViewUser();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
        }

        private void BtnDisactivate_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Deactivate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtusertype.Text == "Administrator")
                {
                    MessageBox.Show("Administrator account cannot be Deactivate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Deactivate this User Account?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtuserstatus.Text = "Deactivate";
                            db.spUpdateUser(int.Parse(labelUserID.Text), txtusername.Text, txtuserpass.Text, txtusertype.Text, txtlastname.Text,
                             txtfirstname.Text, txtemail.Text, txtuserstatus.Text, txtsecretQ.Text, txtsecretA.Text, DateTime.Now);
                            labelUserID.Text = "";
                            txtusername.Text = "";
                            txtuserpass.Text = "";
                            txtusertype.Text = "";
                            txtlastname.Text = "";
                            txtfirstname.Text = "";
                            txtemail.Text = "";
                            txtuserstatus.Text = "";
                            txtsecretQ.Text = "";
                            txtsecretA.Text = "";
                            dgvUsersAcc.DataSource = db.spViewUser();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void TxtsearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.spSearchUser(txtsearchUser.Text);
        }

        private void DgvUsersAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelUserID.Text = dgvUsersAcc.CurrentRow.Cells[0].Value.ToString();
            txtusername.Text = dgvUsersAcc.CurrentRow.Cells[1].Value.ToString();
            txtuserpass.Text = dgvUsersAcc.CurrentRow.Cells[2].Value.ToString();
            txtusertype.Text = dgvUsersAcc.CurrentRow.Cells[3].Value.ToString();
            txtfirstname.Text = dgvUsersAcc.CurrentRow.Cells[4].Value.ToString();
            txtlastname.Text = dgvUsersAcc.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = dgvUsersAcc.CurrentRow.Cells[6].Value.ToString();
            txtuserstatus.Text = dgvUsersAcc.CurrentRow.Cells[7].Value.ToString();
            txtsecretQ.Text = dgvUsersAcc.CurrentRow.Cells[8].Value.ToString();
            txtsecretA.Text = dgvUsersAcc.CurrentRow.Cells[9].Value.ToString();
            txtuserpass.Show();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Users_Management.UsersRegistrationForm urf = new Users_Management.UsersRegistrationForm();
            urf.Show();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a user account to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Users_Management.UsersUpdateForm uuf = new Users_Management.UsersUpdateForm();
                uuf.lblUser_ID.Text = dgvUsersAcc.CurrentRow.Cells[0].Value.ToString();
                uuf.txtuname.Text = dgvUsersAcc.CurrentRow.Cells[1].Value.ToString();
                uuf.txtpass.Text = dgvUsersAcc.CurrentRow.Cells[2].Value.ToString();
                uuf.cmbUsertype.Text = dgvUsersAcc.CurrentRow.Cells[3].Value.ToString();
                uuf.txtlname.Text = dgvUsersAcc.CurrentRow.Cells[5].Value.ToString();
                uuf.txtfname.Text = dgvUsersAcc.CurrentRow.Cells[4].Value.ToString();
                uuf.txtemail.Text = dgvUsersAcc.CurrentRow.Cells[6].Value.ToString();
                uuf.cmbstatus.Text = dgvUsersAcc.CurrentRow.Cells[7].Value.ToString();
                uuf.cmbQuest.Text = dgvUsersAcc.CurrentRow.Cells[8].Value.ToString();
                uuf.txtans.Text = dgvUsersAcc.CurrentRow.Cells[9].Value.ToString();
                uuf.Show();
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtusertype.Text == "Administrator")
                {
                    MessageBox.Show("Administrator account cannot be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.spDeleteUser(int.Parse(labelUserID.Text));
                            labelUserID.Text = "";
                            labelUserID.Text = "";
                            txtusername.Text = "";
                            txtuserpass.Text = "";
                            txtusertype.Text = "";
                            txtlastname.Text = "";
                            txtfirstname.Text = "";
                            txtemail.Text = "";
                            txtuserstatus.Text = "";
                            txtsecretQ.Text = "";
                            txtsecretA.Text = "";
                            dgvUsersAcc.DataSource = db.spViewUser();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void BtnRefreshUser_Click(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.spViewUser();
            labelUserID.Text = "";
            txtusername.Text = "";
            txtuserpass.Text = "";
            txtusertype.Text = "";
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txtemail.Text = "";
            txtuserstatus.Text = "";
            txtsecretQ.Text = "";
            txtsecretA.Text = "";
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Products_Management.ProductAddForm proadd = new Products_Management.ProductAddForm();
            proadd.lblUserID.Text = lblUserID.Text;
            proadd.Show();
        }

        private void BtnUpdatePro_Click(object sender, EventArgs e)
        {
            if (labelProductID.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProCat.Text == "" || txtProQuantity.Text == "" || txtPerBox.Text == "" || txtBox.Text == "" || txtProDesc.Text == "")
            {
                MessageBox.Show("Please select a product to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Products_Management.ProductUpdateForm puf = new Products_Management.ProductUpdateForm();
                puf.lblProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                puf.txtpro_code.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                puf.txtpro_name.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                puf.txtProCat.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                puf.txtpro_price.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                puf.txtpro_quantity.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                puf.txtQuanPerBox.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                puf.txtBox.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();
                puf.txtpro_desc.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString();
                puf.txtProCat.Focus();
                puf.Show();

            }
        }

        private void BtnRefreshPro_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.spViewProducts();
            RowsColor();
            labelProductID.Text = "";
            txtProCode.Text = "";
            txtProName.Text = "";
            txtProCat.Text = "";
            txtpro_quantity.Text = "";
            txtProPrice.Text = "";
            txtProDesc.Text = "";
            txtBox.Text = "";
            txtQuantityPerBox.Text = "";
        }

        private void BtnDeletePro_Click(object sender, EventArgs e)
        {
            if (labelProductID.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProCat.Text == "" || txtProDesc.Text == "" || txtProCode.Text == "")
            {
                MessageBox.Show("Please select product to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.spRemoveProducts(txtProCode.Text) ;
                        labelProductID.Text = "";
                        txtProCode.Text = "";
                        txtProName.Text = "";
                        txtProCat.Text = "";
                        txtProPrice.Text = "";
                        txtProDesc.Text = "";
                        dgvProducts.DataSource = db.spViewProducts();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.spSearchProducts(txtSearchProducts.Text);
            RowsColor();
        }

        private void DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowsColor();
            labelProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtProCode.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtProName.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtProCat.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtProPrice.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtProQuantity.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            txtPerBox.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
            txtBox.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();
            txtProDesc.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString();
        }

        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            Customer_Management.CustomerRegistrationForm crf = new Customer_Management.CustomerRegistrationForm();
            crf.lblUserID.Text = lblUserID.Text;
            crf.Show();
        }

        private void BtnUpdateCust_Click(object sender, EventArgs e)
        {
            if (labelCustomerID.Text == "" || txtCustName.Text == "" || txtCustAdd.Text == "" || txtCustCont.Text == "" || txtCustType.Text == "")
            {
                MessageBox.Show("Please select a customer to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer_Management.CustomerUpdateForm cuf = new Customer_Management.CustomerUpdateForm();
                cuf.lblCust_ID.Text = dgvCustomersAcc.CurrentRow.Cells[0].Value.ToString();
                cuf.txtName.Text = dgvCustomersAcc.CurrentRow.Cells[1].Value.ToString();
                cuf.txtTin.Text = dgvCustomersAcc.CurrentRow.Cells[2].Value.ToString();
                cuf.txtAddress.Text = dgvCustomersAcc.CurrentRow.Cells[3].Value.ToString();
                cuf.txtBstyle.Text = dgvCustomersAcc.CurrentRow.Cells[4].Value.ToString();
                cuf.txtContact.Text = dgvCustomersAcc.CurrentRow.Cells[5].Value.ToString();
                cuf.cmbuCType.Text = dgvCustomersAcc.CurrentRow.Cells[6].Value.ToString();
                cuf.Show();
            }
        }

        private void BtnRefereshCust_Click(object sender, EventArgs e)
        {
            dgvCustomersAcc.DataSource = db.spViewCustomer();
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if (labelCustomerID.Text == "" || txtCustName.Text == "" || txtCustAdd.Text == "" || txtCustCont.Text == "" || txtCustType.Text == "")
            {
                MessageBox.Show("Please Select a Customer to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.spRemoveCustomer(int.Parse(labelCustomerID.Text));
                        labelCustomerID.Text = "";
                        txtCustName.Text = "";
                        txtCustAdd.Text = "";
                        txtCustCont.Text = "";
                        txtCustType.Text = "";
                        dgvCustomersAcc.DataSource = db.spViewCustomer();
                    }

                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void TxtsearchCustomer_TextChanged(object sender, EventArgs e)
        {
            dgvCustomersAcc.DataSource = db.spSearchCustomer(txtsearchCustomer.Text);
        }

        private void DgvCustomersAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelCustomerID.Text = dgvCustomersAcc.CurrentRow.Cells[0].Value.ToString();
            txtCustName.Text = dgvCustomersAcc.CurrentRow.Cells[1].Value.ToString();
            txtCustTin.Text = dgvCustomersAcc.CurrentRow.Cells[2].Value.ToString();
            txtCustAdd.Text = dgvCustomersAcc.CurrentRow.Cells[3].Value.ToString();
            txtCustBstyle.Text = dgvCustomersAcc.CurrentRow.Cells[4].Value.ToString();
            txtCustCont.Text = dgvCustomersAcc.CurrentRow.Cells[5].Value.ToString();
            txtCustType.Text = dgvCustomersAcc.CurrentRow.Cells[6].Value.ToString();
        }
      
        private void BtnInventoryReports_Click(object sender, EventArgs e)
        {
            ViewInventoryReportsForm virf = new ViewInventoryReportsForm();
            virf.Show();
        }

        private void BtnSalesReports_Click(object sender, EventArgs e)
        {
            ViewSalesReportsForm vsrf = new ViewSalesReportsForm();
            vsrf.Show();
        }

        private void BtnSelectPro_Click(object sender, EventArgs e)
        {
            Products_Management.ViewProductsForm pview = new Products_Management.ViewProductsForm();
            pview.ShowInTaskbar = false;
            pview.Location = new Point(275, 160);
            DialogResult aa = pview.ShowDialog();
            if (aa == DialogResult.OK)
            {
                lblProCode.Text = pview.dgvStocks.CurrentRow.Cells[2].Value.ToString();
                txtpro_name.Text = pview.dgvStocks.CurrentRow.Cells[3].Value.ToString();
                txtpro_price.Text = pview.dgvStocks.CurrentRow.Cells[5].Value.ToString();
                txtStockOnHand.Text = pview.dgvStocks.CurrentRow.Cells[6].Value.ToString();
                txtQuantityPerBox.Text = pview.dgvStocks.CurrentRow.Cells[7].Value.ToString();
                txtAvailBox.Text = pview.dgvStocks.CurrentRow.Cells[8].Value.ToString();
                txtpro_quantity.Focus();
            }
        }

        private void BtnSelectCust_Click(object sender, EventArgs e)
        {
            Customers_Management.ViewCustomersForm cview = new Customers_Management.ViewCustomersForm();
            cview.ShowInTaskbar = false;
            cview.Location = new Point(275, 160);
            DialogResult aa = cview.ShowDialog();
            if (aa == DialogResult.OK)
            {
                lblCustID.Text = cview.dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                txtcust_name.Text = cview.dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                lblTin.Text = cview.dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                txtcust_address.Text = cview.dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                lblTotal.Text = cview.dgvCustomer.CurrentRow.Cells[6].Value.ToString();
                lblCustType.Text = cview.dgvCustomer.CurrentRow.Cells[8].Value.ToString();
                txtpro_quantity.Focus();
            }
        }

        private void CmbTranType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTranType.Text == "")
            {
                txtpro_quantity.Enabled = false;
                btnSelectCust.Enabled = false;
                btnSelectPro.Enabled = false;
            }
            else
            {
                
                if (cmbTranType.Text == "Purchase Order")
                {
                    gbWalkin.Show();
                    dgvAddToCart.Show();
                    lblProCode.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    txtStockOnHand.Clear();
                    lblCustID.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtcash.Clear();
                    txtAmount.Clear();
                    lblTin.Text = "";
                    txtchange.Clear();
                    txtQuantityPerBox.Clear();
                    txtAvailBox.Clear();
                    gbOrderPayment.Show();
                    txtpro_quantity.Clear();
                    txtpro_quantity.Enabled = true;
                    btnSelectCust.Enabled = true;
                    btnSelectPro.Enabled = true;
                   
                }
                else
                {
                    gbWalkin.Hide();
                    dgvAddToCart.Hide();
                    lblProCode.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    txtStockOnHand.Clear();
                    lblCustID.Text = "";
                    lblTin.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtcash.Clear();
                    txtAmount.Clear();
                    txtchange.Clear();
                    txtpro_quantity.Clear();
                    txtQuantityPerBox.Clear();
                    txtAvailBox.Clear();
                    gbOrderPayment.Visible = false;
                }
                if (cmbTranType.Text == "Reservation")
                {
                    dtpClaimDate.Show();
                    lblClaimDate.Show();
                    dgvReservation.Show();
                    gbReservation.Show();
                    lblProCode.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    txtStockOnHand.Clear();
                    lblTin.Text = "";
                    lblCustID.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtcash.Clear();
                    txtAmount.Clear();
                    txtchange.Clear();
                    txtQuantityPerBox.Clear();
                    txtAvailBox.Clear();
                    txtpro_quantity.Clear();
                    gbOrderPayment.Show();
                    txtpro_quantity.Enabled = true;
                    btnSelectCust.Enabled = true;
                    btnSelectPro.Enabled = true;
                }
                else
                {
                    dtpClaimDate.Hide();
                    lblClaimDate.Hide();
                    dgvReservation.Hide();
                    gbReservation.Hide();
                    lblProCode.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    txtStockOnHand.Clear();
                    lblCustID.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtpro_quantity.Clear();
                    lblTin.Text = "";
                    txtcash.Clear();
                    txtAmount.Clear();
                    txtchange.Clear();
                }
                if (cmbTranType.Text == "Delivery")
                {
                    dtpDateDel.Show();
                    lblDateDel.Show();
                    dgvDelivery.Show();
                    gbDelivery.Show();
                    lblProCode.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    lblTin.Text = "";
                    txtStockOnHand.Clear();
                    lblCustID.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtcash.Clear();
                    txtAmount.Clear();
                    txtchange.Clear();
                    txtQuantityPerBox.Clear();
                    txtpro_quantity.Clear();
                    txtAvailBox.Clear();
                    gbOrderPayment.Show();
                    txtpro_quantity.Enabled = true;
                    btnSelectCust.Enabled = true;
                    btnSelectPro.Enabled = true;
                }
                else
                {
                    dtpDateDel.Hide();
                    lblDateDel.Hide();
                    dgvDelivery.Hide();
                    gbDelivery.Hide();
                    txtcash.Visible = true;
                    txtchange.Visible = true;
                    lblCash.Visible = true;
                    lblChange.Visible = true;
                    lblProCode.Text = "";
                    lblTin.Text = "";
                    txtpro_name.Clear();
                    txtpro_price.Clear();
                    txtpro_quantity.Clear();
                    txtStockOnHand.Clear();
                    lblCustID.Text = "";
                    txtcust_name.Clear();
                    txtcust_address.Clear();
                    txtcash.Clear();
                    txtAmount.Clear();
                    txtchange.Clear();
                    txtQuantityPerBox.Clear();
                    txtAvailBox.Clear();
                }
            }
        }

        private void Txtcash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal changed = 0;

                if (txtcash.Text == "")
                {
                    btnPrintOrder.Enabled = false;
                    btnDel.Enabled = false;
                    btnRes.Enabled = false;
                    txtchange.Text = "";

                    if (cmbTranType.Text == "Purchase Order")
                    {
                        decimal Total = 0;
                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();
                    }
                    else if (cmbTranType.Text == "Reservation")
                    {
                        decimal Total = 0;
                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvReservation.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();
                    }
                    else if (cmbTranType.Text == "Delivery")
                    {
                        decimal Total = 0;
                        for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvDelivery.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();
                    }
                }
                else
                {
                    if (txtAmount.Text == "0")
                    {
                        btnPrintOrder.Enabled = false;
                        btnDel.Enabled = false;
                        btnRes.Enabled = false;
                        txtchange.Text = "";
                    }
                    else
                    {
                        decimal TotalAmount = decimal.Parse(txtAmount.Text);
                        decimal Cash = decimal.Parse(txtcash.Text);
                        changed = Cash - TotalAmount;
                        txtchange.Text = changed.ToString();

                        if (Cash < TotalAmount)
                        {
                            btnPrintOrder.Enabled = false;
                            btnDel.Enabled = false;
                            btnRes.Enabled = false;
                        }
                        else
                        {
                            btnPrintOrder.Enabled = true;
                            btnDel.Enabled = true;
                            btnRes.Enabled = true;
                        }
                    }
                }
            }
            catch
            { }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTranType.Text == "")
                {
                    MessageBox.Show("Please Select Transaction type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                    if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtStockOnHand.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                            if (txtpro_quantity.Text == "")
                        {
                            MessageBox.Show("Please Input order quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtpro_quantity.Focus();
                        }
                        else
                        {
                      
                            decimal Proprice = decimal.Parse(txtpro_price.Text);
                            int Pquantity = int.Parse(txtpro_quantity.Text);
                            int StockonHand = int.Parse(txtStockOnHand.Text);
                            int StRemain = 0;
                            decimal TotalAmount = 0;
                            decimal Box = decimal.Parse(txtAvailBox.Text);
                            decimal Balance = StockonHand - Pquantity;
                            decimal BoxBalance = Balance / Box;
                            if
                           (Pquantity > StockonHand)
                            {

                                MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtpro_quantity.Focus();
                            }
                            else
                            {
                                if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                {
                                    MessageBox.Show("Please select a customer information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtcust_name.Focus();
                                }
                                else
                                {
                                    if (int.Parse(txtpro_quantity.Text) <= 0)
                                    {
                                        MessageBox.Show("Number must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtpro_quantity.Text = "";
                                    }
                                    else
                                    {
                                        TotalAmount = Proprice * Pquantity;
                                        StRemain = StockonHand - Pquantity;
                                        lblStockIn.Text = "0";
                                        db.spAddCart(lblProCode.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, lblTin.Text, DateTime.Now, cmbTranType.Text, int.Parse(lblCustID.Text), ClsLogin.User.UserId, StRemain, int.Parse(txtQuantityPerBox.Text), BoxBalance);
                                        db.spAddInventory(txtProCode.Text, StRemain, int.Parse(lblStockIn.Text), Pquantity, BoxBalance, DateTime.Now);
                                        DataGridViewRow newDataRow = dgvProducts.Rows[IndexRow];
                                        newDataRow.Cells[7].Value = StRemain.ToString();
                                        db.spUpdateProduct(lblProCode.Text, int.Parse(txtpro_quantity.Text), decimal.Parse(lblBox2.Text));
                                        dgvAddToCart.DataSource = db.spViewCart();
                                        MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        decimal Total = 0;
                                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                                        {
                                            Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
                                        }
                                        txtAmount.Text = Total.ToString();

                                        txtQuantityPerBox.Text = "";
                                        txtAvailBox.Text = "";
                                        lblBox2.Text = "";
                                        lblProCode.Text = "";
                                        txtpro_name.Text = "";
                                        txtpro_price.Text = "";
                                        txtStockOnHand.Text = "";
                                        txtpro_quantity.Text = "";
                                        txtQuantityPerBox.Text = "";
                                        txtAvailBox.Text = "";
                                        lblTin.Text = "";
                                        txtcash.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtQuantityPerBox.Text == "" || lblQuantity.Text == "" || txtcust_name.Text == "" || txtcust_address.Text == "")
                {
                    MessageBox.Show("Please select Order Product to cancel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel order?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblStockOut.Text = "0";
                        int Stock = int.Parse(txtStockOnHand.Text);
                        int ProQuantity = int.Parse(lblQuantity.Text);
                        int PerBox = int.Parse(txtQuantityPerBox.Text);
                        decimal Box = decimal.Parse(txtAvailBox.Text);
                        int StRemain = Stock + ProQuantity;
                        Box = StRemain / PerBox;
                        db.spCancelOrder(int.Parse(lblQuantity.Text), lblProCode.Text, decimal.Parse(lblBox2.Text));
                        db.spAddInventory(txtProCode.Text, StRemain, int.Parse(lblStockIn.Text), int.Parse(lblStockOut.Text), Box, DateTime.Now);
                        db.spDeleteCart(int.Parse(lblOrderID.Text));
                        dgvProducts.DataSource = db.spViewProducts();
                        dgvAddToCart.DataSource = db.spViewCart();
                        decimal Total = 0;
                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();

                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblBox2.Text = "";
                        lblProCode.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = ""; 
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtStockOnHand.Text = "";
                        txtpro_quantity.Text = "";
                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblTin.Text = "";
                        txtcash.Focus();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        dgvAddToCart.Rows.Add(dgvAddToCart.CurrentRow);
                    }
                }
            }
            catch { }
        }

        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtcash.Text == "" || txtchange.Text == "")
                {
                    MessageBox.Show("Please input amount of cash to pay!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    decimal cash = decimal.Parse(txtcash.Text);
                    decimal amount = decimal.Parse(txtAmount.Text);
                    if (cash < amount)
                    {
                        MessageBox.Show("Cash is not enough to purchase products!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                        {
                            var salesReport = new SalesReport
                            {
                                ProductCode = dgvAddToCart.Rows[i].Cells[0].Value.ToString(),
                                OrderQuantity = int.Parse(dgvAddToCart.Rows[i].Cells[3].Value.ToString()),
                                TotalPrice = decimal.Parse(dgvAddToCart.Rows[i].Cells[4].Value.ToString()),
                                Date = DateTime.Parse(dgvAddToCart.Rows[i].Cells[8].Value.ToString()),
                                TransactionType = dgvAddToCart.Rows[i].Cells[9].Value.ToString(),
                                CustomerID = int.Parse(dgvAddToCart.Rows[i].Cells[10].Value.ToString()),
                                UserID = int.Parse(dgvAddToCart.Rows[i].Cells[11].Value.ToString())
                            };
                            db.SalesReports.InsertOnSubmit(salesReport);
                        }
                        db.SubmitChanges();

                        for (int p = 0; p < dgvAddToCart.Rows.Count; p++)
                        {
                            var AddCart = new AddToCart
                                {
                                    ProductCode = dgvAddToCart.Rows[p].Cells[0].Value.ToString(),
                                    ProductName = dgvAddToCart.Rows[p].Cells[1].Value.ToString(),
                                    ProductPrice = decimal.Parse(dgvAddToCart.Rows[p].Cells[2].Value.ToString()),
                                    OrderQuantity = int.Parse(dgvAddToCart.Rows[p].Cells[3].Value.ToString()),
                                    TotalAmount = decimal.Parse(dgvAddToCart.Rows[p].Cells[4].Value.ToString()),
                                    CustomerName = dgvAddToCart.Rows[p].Cells[5].Value.ToString(),
                                    CustomerAddress = dgvAddToCart.Rows[p].Cells[6].Value.ToString(),
                                    CustomerTin = dgvAddToCart.Rows[p].Cells[7].Value.ToString(),
                                    Date = DateTime.Parse(dgvAddToCart.Rows[p].Cells[8].Value.ToString()),
                                    TransactionType = dgvAddToCart.Rows[p].Cells[9].Value.ToString(),
                                    CustomerID = int.Parse(dgvAddToCart.Rows[p].Cells[10].Value.ToString()),
                                    UserID = int.Parse(dgvAddToCart.Rows[p].Cells[11].Value.ToString()),
                                    QuantityPerBox = int.Parse(dgvAddToCart.Rows[p].Cells[12].Value.ToString()),
                                    OrderID = int.Parse(dgvAddToCart.Rows[p].Cells[13].Value.ToString()),
                                };
                                dgvAddToCart.DataSource = db.spViewCart();
                        }
                        db.SubmitChanges();

                        lblProCode.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtStockOnHand.Text = "";
                        txtpro_quantity.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtcash.Text = "";
                        txtAmount.Text = "";
                        txtchange.Text = "";

                    }
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void DgvAddToCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProCode.Text = dgvAddToCart.CurrentRow.Cells[0].Value.ToString();
            txtpro_name.Text = dgvAddToCart.CurrentRow.Cells[1].Value.ToString();
            txtpro_price.Text = dgvAddToCart.CurrentRow.Cells[2].Value.ToString();
            txtpro_quantity.Text = dgvAddToCart.CurrentRow.Cells[3].Value.ToString();
            lblQuantity.Text = dgvAddToCart.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgvAddToCart.CurrentRow.Cells[4].Value.ToString();
            txtcust_name.Text = dgvAddToCart.CurrentRow.Cells[5].Value.ToString();
            txtcust_address.Text = dgvAddToCart.CurrentRow.Cells[6].Value.ToString();
            lblTin.Text = dgvAddToCart.CurrentRow.Cells[7].Value.ToString();
            cmbTranType.Text = dgvAddToCart.CurrentRow.Cells[9].Value.ToString();
            lblCustID.Text = dgvAddToCart.CurrentRow.Cells[10].Value.ToString();
            txtStockOnHand.Text = dgvAddToCart.CurrentRow.Cells[12].Value.ToString();
            txtQuantityPerBox.Text = dgvAddToCart.CurrentRow.Cells[13].Value.ToString();
            txtAvailBox.Text = dgvAddToCart.CurrentRow.Cells[14].Value.ToString();
            lblOrderID.Text = dgvAddToCart.CurrentRow.Cells[15].Value.ToString();
        }

        private void PnlCustOrder_Paint(object sender, PaintEventArgs e)
        {
            dgvAddToCart.DataSource = db.spViewCart();
            dgvDelivery.DataSource = db.spViewDelCart();
            dgvReservation.DataSource = db.spViewResCart();
            decimal Totals = 0;
            btnPrintOrder.Enabled = false;
            btnDel.Enabled = false;
            btnRes.Enabled = false;
            for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
            {
                Totals += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
            }
            txtAmount.Text = Totals.ToString();
            if (cmbTranType.Text == "Purchase Order")
            {
                decimal Total = 0;
                for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
                }
                txtAmount.Text = Total.ToString();
            }
            else if (cmbTranType.Text == "Reservation")
            {
                decimal Total = 0;
                for (int i = 0; i < dgvReservation.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dgvReservation.Rows[i].Cells[4].Value);
                }
                txtAmount.Text = Total.ToString();
            }
            else if (cmbTranType.Text == "Delivery")
            {
                decimal Total = 0;
                for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dgvDelivery.Rows[i].Cells[4].Value);
                }
                txtAmount.Text = Total.ToString();
            }
        }

        private void BtnAddDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTranType.Text == "")
                {
                    MessageBox.Show("Please Select Transaction type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {

                    if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtStockOnHand.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                            if (txtpro_quantity.Text == "")
                        {
                            MessageBox.Show("Please Input order quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtpro_quantity.Focus();
                        }
                        else
                        {
                            if (lblCustType.Text == "Walk-in Client")
                            {
                                MessageBox.Show("Walk-in Clients cannot transact in products delivery!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                decimal Proprice = decimal.Parse(txtpro_price.Text);
                                int Pquantity = int.Parse(txtpro_quantity.Text);
                                int StockonHand = int.Parse(txtStockOnHand.Text);
                                int StRemain = 0;
                                decimal TotalAmount = 0;
                                decimal Box = decimal.Parse(txtAvailBox.Text);
                                decimal Balance = StockonHand - Pquantity;
                                decimal BoxBalance = Balance / Box;
                                if
                               (Pquantity > StockonHand)
                                {

                                    MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtpro_quantity.Focus();
                                }
                                else
                                {
                                    if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                    {
                                        MessageBox.Show("Please select a customer information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtcust_name.Focus();
                                    }
                                    else
                                    {
                                        if (int.Parse(txtpro_quantity.Text) <= 0)
                                        {
                                            MessageBox.Show("Number must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtpro_quantity.Text = "";
                                        }
                                        else
                                        {
                                            if (int.Parse(txtpro_quantity.Text) <= 14)
                                            {
                                                MessageBox.Show("Cannot transact Delivery, Order Quantity should be more than 14!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                if (dtpDateDel.Value.Date >= DateTime.Now.AddDays(-1) && dtpDateDel.Value.Date <= DateTime.Now.Date)
                                                {
                                                    MessageBox.Show("Delivery Date should not be backwards", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    lblDelStatus.Text = "Not Delivered";
                                                    TotalAmount = Proprice * Pquantity;
                                                    StRemain = StockonHand - Pquantity;
                                                    lblStockIn.Text = "0";
                                                    db.spAddDelCart(lblProCode.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, lblTin.Text, dtpDateDel.Value, cmbTranType.Text, DateTime.Now, int.Parse(lblCustID.Text), int.Parse(lblUserID.Text), lblDelStatus.Text, StRemain, int.Parse(txtQuantityPerBox.Text), BoxBalance);
                                                    db.spAddInventory(txtProCode.Text, StRemain, int.Parse(lblStockIn.Text), Pquantity, BoxBalance, DateTime.Now);
                                                    DataGridViewRow newDataRow = dgvProducts.Rows[IndexRow];
                                                    newDataRow.Cells[7].Value = StRemain.ToString();
                                                    db.spUpdateProduct(lblProCode.Text, int.Parse(txtpro_quantity.Text), decimal.Parse(lblBox2.Text));
                                                    dgvDelivery.DataSource = db.spViewDelCart();
                                                    MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    decimal Total = 0;
                                                    for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                                                    {
                                                        Total += Convert.ToDecimal(dgvDelivery.Rows[i].Cells[4].Value);
                                                    }
                                                    txtAmount.Text = Total.ToString();
                                                    
                                                    txtQuantityPerBox.Text = "";
                                                    txtAvailBox.Text = "";                                           
                                                    lblProCode.Text = "";
                                                    txtpro_name.Text = "";
                                                    txtpro_price.Text = "";
                                                    txtStockOnHand.Text = "";
                                                    txtpro_quantity.Text = "";
                                                    lblTin.Text = "";
                                                    txtcash.Focus();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnResPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTranType.Text == "")
                {
                    MessageBox.Show("Please Select Transaction type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                    if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtStockOnHand.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                            if (txtpro_quantity.Text == "")
                        {
                            MessageBox.Show("Please Input order quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtpro_quantity.Focus();
                        }
                        else
                        {
                            if (lblCustType.Text == "Walk-in Client")
                            {
                                MessageBox.Show("Walk-in Clients cannot transact in products reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                decimal Proprice = decimal.Parse(txtpro_price.Text);
                                int Pquantity = int.Parse(txtpro_quantity.Text);
                                int StockonHand = int.Parse(txtStockOnHand.Text);
                                int StRemain = 0;
                                decimal TotalAmount = 0;
                                decimal Box = decimal.Parse(txtAvailBox.Text);
                                decimal Balance = StockonHand - Pquantity;
                                decimal BoxBalance = Balance / Box;
                                if
                               (Pquantity > StockonHand)
                                {

                                    MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtpro_quantity.Focus();
                                }
                                else
                                {
                                    if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                    {
                                        MessageBox.Show("Please select a customer information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtcust_name.Focus();
                                    }
                                    else
                                    {
                                        if (int.Parse(txtpro_quantity.Text) <= 0)
                                        {
                                            MessageBox.Show("Number must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtpro_quantity.Text = "";
                                        }
                                        else
                                        {
                                            if (int.Parse(txtpro_quantity.Text) <= 14)
                                            {
                                                MessageBox.Show("Cannot transact Delivery, Order Quantity should be more than 14!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                    if (dtpDateDel.Value.Date >= DateTime.Now.Date)
                                                    {
                                                        MessageBox.Show("Claim Date should not be backwards", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                    lblResStatus.Text = "Unclaim";
                                                    TotalAmount = Proprice * Pquantity;
                                                    StRemain = StockonHand - Pquantity;
                                                    lblStockIn.Text = "0";
                                                    db.spAddResCart(lblProCode.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, lblTin.Text, dtpClaimDate.Value, cmbTranType.Text, DateTime.Now, int.Parse(lblCustID.Text), int.Parse(lblUserID.Text), lblResStatus.Text, StRemain, int.Parse(txtQuantityPerBox.Text), BoxBalance);
                                                    db.spAddInventory(txtProCode.Text, StRemain, int.Parse(lblStockIn.Text), Pquantity, BoxBalance, DateTime.Now);
                                                    DataGridViewRow newDataRow = dgvProducts.Rows[IndexRow];
                                                    newDataRow.Cells[7].Value = StRemain.ToString();
                                                    db.spUpdateProduct(lblProCode.Text, int.Parse(txtpro_quantity.Text), decimal.Parse(lblBox2.Text));
                                                    dgvReservation.DataSource = db.spViewResCart();
                                                    MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    decimal Total = 0;
                                                    for (int i = 0; i < dgvReservation.Rows.Count; i++)
                                                    {
                                                        Total += Convert.ToDecimal(dgvReservation.Rows[i].Cells[4].Value);
                                                    }
                                                    txtAmount.Text = Total.ToString();

                                                    txtQuantityPerBox.Text = "";
                                                    txtAvailBox.Text = "";
                                                    lblProCode.Text = "";
                                                    txtpro_name.Text = "";
                                                    txtpro_price.Text = "";
                                                    txtStockOnHand.Text = "";
                                                    txtpro_quantity.Text = "";
                                                    lblTin.Text = "";
                                                    txtcash.Focus();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void DgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProCode.Text = dgvDelivery.CurrentRow.Cells[0].Value.ToString();
            txtpro_name.Text = dgvDelivery.CurrentRow.Cells[1].Value.ToString();
            txtpro_price.Text = dgvDelivery.CurrentRow.Cells[2].Value.ToString();
            txtpro_quantity.Text = dgvDelivery.CurrentRow.Cells[3].Value.ToString();
            lblQuantity.Text = dgvDelivery.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgvDelivery.CurrentRow.Cells[4].Value.ToString();
            txtcust_name.Text = dgvDelivery.CurrentRow.Cells[5].Value.ToString();
            txtcust_address.Text = dgvDelivery.CurrentRow.Cells[6].Value.ToString();
            lblTin.Text = dgvDelivery.CurrentRow.Cells[7].Value.ToString();
            dtpDateDel.Value = DateTime.Parse(dgvDelivery.CurrentRow.Cells[8].Value.ToString());
            cmbTranType.Text = dgvDelivery.CurrentRow.Cells[9].Value.ToString();
            lblCustID.Text = dgvDelivery.CurrentRow.Cells[11].Value.ToString();
            lblDelStatus.Text = dgvDelivery.CurrentRow.Cells[13].Value.ToString();
            txtStockOnHand.Text = dgvDelivery.CurrentRow.Cells[14].Value.ToString();
            txtQuantityPerBox.Text = dgvDelivery.CurrentRow.Cells[15].Value.ToString();
            txtAvailBox.Text = dgvDelivery.CurrentRow.Cells[16].Value.ToString();
            lblOrderID.Text = dgvDelivery.CurrentRow.Cells[17].Value.ToString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                {
                    var delivery = new ProductsDelivery
                    {
                        ProductCode = dgvDelivery.Rows[i].Cells[0].Value.ToString(),
                        OrderQuantity = int.Parse(dgvDelivery.Rows[i].Cells[3].Value.ToString()),
                        TotalPrice = decimal.Parse(dgvDelivery.Rows[i].Cells[4].Value.ToString()),
                        DeliveryDate = DateTime.Parse(dgvDelivery.Rows[i].Cells[8].Value.ToString()),
                        TransactionType = dgvDelivery.Rows[i].Cells[9].Value.ToString(),
                        Date = DateTime.Parse(dgvDelivery.Rows[i].Cells[10].Value.ToString()),
                        CustomerID = int.Parse(dgvDelivery.Rows[i].Cells[11].Value.ToString()),
                        UserID = int.Parse(dgvDelivery.Rows[i].Cells[12].Value.ToString()),
                        DeliveryStatus = dgvDelivery.Rows[i].Cells[13].Value.ToString()
                    };
                    db.ProductsDeliveries.InsertOnSubmit(delivery);
                    dgvCustDelivery.DataSource = db.spSelectDelivery();

                    var deliveryCart = new DeliveryCart
                    {
                        ProductCode = dgvDelivery.Rows[i].Cells[0].Value.ToString(),
                        ProductName = dgvDelivery.Rows[i].Cells[1].Value.ToString(),
                        ProductPrice = Decimal.Parse(dgvDelivery.Rows[i].Cells[2].Value.ToString()),
                        OrderQuantity = int.Parse(dgvDelivery.Rows[i].Cells[3].Value.ToString()),
                        TotalAmount = decimal.Parse(dgvDelivery.Rows[i].Cells[4].Value.ToString()),
                        CustomerName = dgvDelivery.Rows[i].Cells[5].Value.ToString(),
                        CustomerAddress = dgvDelivery.Rows[i].Cells[6].Value.ToString(),
                        CustomerTin = dgvDelivery.Rows[i].Cells[7].Value.ToString(),
                        DeliveryDate = DateTime.Parse(dgvDelivery.Rows[i].Cells[8].Value.ToString()),
                        TransactionType = dgvDelivery.Rows[i].Cells[9].Value.ToString(),
                        date = DateTime.Parse(dgvDelivery.Rows[i].Cells[10].Value.ToString()),
                        CustomerID = int.Parse(dgvDelivery.Rows[i].Cells[11].Value.ToString()),
                        UserID = int.Parse(dgvDelivery.Rows[i].Cells[12].Value.ToString()),
                        DeliveryStatus = dgvDelivery.Rows[i].Cells[13].Value.ToString(),
                        QuantityPerBox = int.Parse(dgvDelivery.Rows[i].Cells[14].Value.ToString()),
                        OrderID = int.Parse(dgvDelivery.Rows[i].Cells[15].Value.ToString()),
                    };
                    db.DeliveryCarts.DeleteOnSubmit(deliveryCart);
                }
                db.SubmitChanges();
                lblProCode.Text = "";
                txtpro_name.Text = "";
                txtpro_price.Text = "";
                txtStockOnHand.Text = "";
                txtpro_quantity.Text = "";
                lblCustID.Text = "";
                txtcust_name.Text = "";
                txtcust_address.Text = "";
                txtcash.Text = "";
                txtAmount.Text = "";
                txtchange.Text = "";;

            }
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcash.Text == "" || txtchange.Text == "")
                {
                    MessageBox.Show("Please input amount of cash to pay!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal cash = decimal.Parse(txtcash.Text);
                    decimal amount = decimal.Parse(txtAmount.Text);
                    if (cash < amount)
                    {
                        MessageBox.Show("Cash is not enough to purchase products!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                        {
                            var salesReport = new SalesReport
                            {
                                ProductCode = dgvReservation.Rows[i].Cells[0].Value.ToString(),
                                OrderQuantity = int.Parse(dgvReservation.Rows[i].Cells[3].Value.ToString()),
                                TotalPrice = decimal.Parse(dgvReservation.Rows[i].Cells[4].Value.ToString()),
                                TransactionType = dgvReservation.Rows[i].Cells[9].Value.ToString(),
                                Date = DateTime.Parse(dgvReservation.Rows[i].Cells[10].Value.ToString()),
                                CustomerID = int.Parse(dgvReservation.Rows[i].Cells[11].Value.ToString()),
                                UserID = int.Parse(dgvReservation.Rows[i].Cells[12].Value.ToString())
                            };
                            db.SalesReports.InsertOnSubmit(salesReport);
                       
                            var reservation = new ProductsReservation
                            {
                                ProductCode = dgvReservation.Rows[i].Cells[0].Value.ToString(),
                                OrderQuantity = int.Parse(dgvReservation.Rows[i].Cells[3].Value.ToString()),
                                TotalPrice = decimal.Parse(dgvReservation.Rows[i].Cells[4].Value.ToString()),
                                ClaimDate = DateTime.Parse(dgvReservation.Rows[i].Cells[8].Value.ToString()),
                                TransactionType = dgvReservation.Rows[i].Cells[9].Value.ToString(),
                                Date = DateTime.Parse(dgvReservation.Rows[i].Cells[10].Value.ToString()),
                                CustomerID = int.Parse(dgvReservation.Rows[i].Cells[11].Value.ToString()),
                                UserID = int.Parse(dgvReservation.Rows[i].Cells[12].Value.ToString()),
                                ReservationStatus = dgvReservation.Rows[i].Cells[13].Value.ToString()
                            };
                            db.ProductsReservations.InsertOnSubmit(reservation);
                            dgvCustReservation.DataSource = db.spSelectReservation();

                            var ReservationCart = new ReservationCart
                            {
                                ProductCode = dgvReservation.Rows[i].Cells[0].Value.ToString(),
                                ProductName = dgvReservation.Rows[i].Cells[1].Value.ToString(),
                                ProductPrice = Decimal.Parse(dgvReservation.Rows[i].Cells[2].Value.ToString()),
                                OrderQuantity = int.Parse(dgvReservation.Rows[i].Cells[3].Value.ToString()),
                                TotalAmount = decimal.Parse(dgvReservation.Rows[i].Cells[4].Value.ToString()),
                                CustomerName = dgvReservation.Rows[i].Cells[5].Value.ToString(),
                                CustomerAddress = dgvReservation.Rows[i].Cells[6].Value.ToString(),
                                CustomerTin = dgvReservation.Rows[i].Cells[7].Value.ToString(),
                                ClaimDate = DateTime.Parse(dgvReservation.Rows[i].Cells[8].Value.ToString()),
                                TransactionType = dgvReservation.Rows[i].Cells[9].Value.ToString(),
                                date = DateTime.Parse(dgvReservation.Rows[i].Cells[10].Value.ToString()),
                                CustomerID = int.Parse(dgvReservation.Rows[i].Cells[11].Value.ToString()),
                                UserID = int.Parse(dgvReservation.Rows[i].Cells[12].Value.ToString()),
                                ReservationStatus = dgvReservation.Rows[i].Cells[13].Value.ToString(),
                                QuantityPerBox = int.Parse(dgvReservation.Rows[i].Cells[14].Value.ToString()),
                                OrderID = int.Parse(dgvDelivery.Rows[i].Cells[15].Value.ToString()),
                            };
                            db.ReservationCarts.DeleteOnSubmit(ReservationCart);
                            dgvReservation.DataSource = db.spViewResCart();
                        }
                        db.SubmitChanges();
                        lblProCode.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtStockOnHand.Text = "";
                        txtpro_quantity.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtcash.Text = "";
                        txtAmount.Text = "";
                        txtchange.Text = "";
                    }
                }
            }
        }

        private void BtnDelStatus_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlDelivery.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void btnResStatus_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void DgvCustDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDeliveryID.Text = dgvCustDelivery.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvCustDelivery.CurrentRow.Cells[2].Value.ToString();
            txtQuantity.Text = dgvCustDelivery.CurrentRow.Cells[3].Value.ToString();
            txtDeliveryDate.Text = dgvCustDelivery.CurrentRow.Cells[6].Value.ToString();
            txtCustomerName.Text = dgvCustDelivery.CurrentRow.Cells[8].Value.ToString();
            txtCustomerAddress.Text = dgvCustDelivery.CurrentRow.Cells[9].Value.ToString();
            cmbDelStatus.Text = dgvCustDelivery.CurrentRow.Cells[7].Value.ToString();
            lblCustoID.Text = dgvCustDelivery.CurrentRow.Cells[10].Value.ToString();
            lblTransactionType.Text = dgvCustDelivery.CurrentRow.Cells[5].Value.ToString();
            lblProductCode.Text = dgvCustDelivery.CurrentRow.Cells[1].Value.ToString();
            lblTotalPrice.Text = dgvCustDelivery.CurrentRow.Cells[4].Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void DgvCustReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblResID.Text = dgvCustReservation.CurrentRow.Cells[0].Value.ToString();
            txtPName.Text = dgvCustReservation.CurrentRow.Cells[2].Value.ToString();
            txtResQuantity.Text = dgvCustReservation.CurrentRow.Cells[4].Value.ToString();
            txtClaimDate.Text = dgvCustReservation.CurrentRow.Cells[6].Value.ToString();
            txtCName.Text = dgvCustReservation.CurrentRow.Cells[8].Value.ToString();
            txtCAddress.Text = dgvCustReservation.CurrentRow.Cells[9].Value.ToString();
            cmbReservationStatus.Text = dgvCustReservation.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnUpdateResPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPName.Text == "" || txtResQuantity.Text == "" || txtClaimDate.Text == "" || txtCName.Text == "" || txtCAddress.Text == "")
                {
                    MessageBox.Show("Please select product ordered to update Delivery!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbReservationStatus.Text == "Claimed") 
                    {
                        db.spUpdateReservation(int.Parse(lblResID.Text), cmbReservationStatus.Text);
                        lblResID.Text = "";
                        MessageBox.Show("Delivery Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvReservation.DataSource = db.spSelectReservation();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Status Cannot be updated unless the products has been claimed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtQuantity.Text == "" || txtDeliveryDate.Text == "" || txtCustomerName.Text == "" || txtCustomerAddress.Text == "")
                {
                    MessageBox.Show("Please select product ordered to update Delivery!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbDelStatus.Text == "Delivered")
                    {
                        db.spUpdateDelivery(int.Parse(lblDeliveryID.Text), cmbDelStatus.Text);
                        db.spAddSalesReports(lblProductCode.Text, int.Parse(txtQuantity.Text), int.Parse(lblTotalPrice.Text), lblTransactionType.Text, int.Parse(lblCustoID.Text), ClsLogin.User.UserId, DateTime.Now) ;
                        lblDeliveryID.Text = "";
                        MessageBox.Show("Delivery Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewSalesReportsForm vsr = new ViewSalesReportsForm();
                        //vsr.dgvSalesInventory.DataSource = db.spViewSalesReports();
                        dgvCustDelivery.DataSource = db.spSelectDelivery();
                    }
                    else
                    {
                        MessageBox.Show("Delivery Status Cannot be Updated unless the product has been delivered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CancelRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtQuantityPerBox.Text == "" || lblQuantity.Text == "" || txtcust_name.Text == "" || txtcust_address.Text == "")
                {
                    MessageBox.Show("Please select Order Product to cancel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel order?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {

                        lblStockOut.Text = "0";
                        int Stock = int.Parse(txtStockOnHand.Text);
                        int ProQuantity = int.Parse(lblQuantity.Text);
                        int PerBox = int.Parse(txtQuantityPerBox.Text);
                        decimal Box = decimal.Parse(txtAvailBox.Text);
                        int StRemain = Stock + ProQuantity;
                        Box = StRemain / PerBox;
                        db.spCancelOrder(int.Parse(lblQuantity.Text), lblProCode.Text, decimal.Parse(lblBox2.Text));
                        db.spAddInventory(txtProCode.Text, StRemain, int.Parse(lblStockIn.Text), int.Parse(lblStockOut.Text), Box, DateTime.Now);
                        db.spDeleteResCart(int.Parse(lblOrderID.Text));
                        dgvProducts.DataSource = db.spViewProducts();
                        dgvReservation.DataSource = db.spViewResCart();
                        decimal Total = 0;
                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvReservation.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();

                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblBox2.Text = "";
                        lblProCode.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtStockOnHand.Text = "";
                        txtpro_quantity.Text = "";
                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblTin.Text = "";
                        txtcash.Focus();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        dgvReservation.Rows.Add(dgvReservation.CurrentRow);
                    }
                }
            }
            catch { }
        }

        private void BtnCancelDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtQuantityPerBox.Text == "" || lblQuantity.Text == "" || txtcust_name.Text == "" || txtcust_address.Text == "")
                {
                    MessageBox.Show("Please select Order Product to cancel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpro_quantity.Focus();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel order?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {

                        lblStockOut.Text = "0";
                        int Stock = int.Parse(txtStockOnHand.Text);
                        int ProQuantity = int.Parse(lblQuantity.Text);
                        int PerBox = int.Parse(txtQuantityPerBox.Text);
                        decimal Box = decimal.Parse(txtAvailBox.Text);
                        int StRemain = Stock + ProQuantity;
                        Box = StRemain / PerBox;
                        db.spCancelOrder(int.Parse(lblQuantity.Text), lblProCode.Text, decimal.Parse(lblBox2.Text));
                        db.spAddInventory(lblProCode.Text, StRemain, int.Parse(txtpro_quantity.Text), int.Parse(lblStockOut.Text), Box, DateTime.Now);
                        db.spDeleteDelCart(int.Parse(lblOrderID.Text));
                        dgvProducts.DataSource = db.spViewProducts();
                        dgvDelivery.DataSource = db.spViewDelCart();
                        decimal Total = 0;
                        for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                        {
                            Total += Convert.ToDecimal(dgvDelivery.Rows[i].Cells[4].Value);
                        }
                        txtAmount.Text = Total.ToString();

                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblBox2.Text = "";
                        lblProCode.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtStockOnHand.Text = "";
                        txtpro_quantity.Text = "";
                        txtQuantityPerBox.Text = "";
                        txtAvailBox.Text = "";
                        lblTin.Text = "";
                        txtcash.Focus();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        dgvDelivery.Rows.Add(dgvDelivery.CurrentRow);
                    }
                }
            }
            catch { }
        }

        private void PnlDelivery_Paint(object sender, PaintEventArgs e)
        {
            dgvCustDelivery.DataSource = db.spSelectDelivery();
        }

        private void BtnProDelivery_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlDelivery.Show();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnProRes_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnStaffHome_Click(object sender, EventArgs e)
        {
            pnlSystemTitle.Show();
            pnlStaffMainMenu.Show();
            pnlStaffHeader.Hide();
            pnlReservation.Hide();
            pnlDelivery.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffTransact_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlStaffHeader.Show();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnManageCustomer_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlProReg.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

      

        private void BtnStaffDelStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlDelivery.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            pnlProReg.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffResStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlStaffMainMenu.Hide();
            pnlProReg.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffTransaction_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlStaffHeader.Show();
            pnlCust_reg.Hide();
            pnlAdminMenu.Hide();
            pnlProReg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnStaffCustomerReg_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlProReg.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffDeliveryStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlDelivery.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffReservationStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlProReg.Hide();
            pnlSystemTitle.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void PbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void PnlSystemTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtpro_quantity_TextChanged(object sender, EventArgs e)
        {
            //double Quantity = 0.0;
            //double Box = 0.0;
            //double PerBox = 0.0;
            //double Stocks = 0.0;
            //double Balance = 0.0;
            //try
            //{
            //    PerBox = double.Parse(txtQuantityPerBox.Text);
            //    Quantity = double.Parse(txtpro_quantity.Text);
            //    Stocks = double.Parse(txtStockOnHand.Text);
            //    Balance = Stocks - Quantity;
            //    Box = Balance / PerBox;
            //    lblBox.Text = Box.ToString();
            //}
            //catch
            //{ }
            double Quantity = 0.00;
            double Box = 0.00;
            double PerBox = 0.00;
            try
            {
                PerBox = double.Parse(txtQuantityPerBox.Text);
                Quantity = double.Parse(txtpro_quantity.Text);
                Box = Quantity / PerBox;
                lblBox2.Text = Box.ToString();
            }
            catch
            { }
        }

        private void Txtpro_stock_TextChanged(object sender, EventArgs e)
        {
            if (txtStockOnHand.Text == "0")
            {
                MessageBox.Show("Out Of stocks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpro_quantity.Enabled = false;
            }
            else
            {
                txtpro_quantity.Enabled = true;
            }
        }

        private void PnlReservation_Paint(object sender, PaintEventArgs e)
        {
            dgvCustReservation.DataSource = db.spSelectReservation();
        }

        private void BtnStaffManageProducts_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlProReg.Show();
            pnlDelivery.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnlProReg.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlCust_reg.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void Txtcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Txtpro_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void BtnAddProStocks_Click(object sender, EventArgs e)
        {
            if (labelProductID.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProCat.Text == "" || txtProQuantity.Text == "" || txtPerBox.Text == "" || txtBox.Text == "" || txtProDesc.Text == "")
            {
                MessageBox.Show("Please select a product to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Products_Management.AddProductStocksForm1cs apsf = new Products_Management.AddProductStocksForm1cs();
                apsf.lblProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                apsf.txtpro_code.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                apsf.txtpro_name.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                apsf.txtPro_Cat.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                apsf.txtpro_price.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                apsf.lblStock.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                apsf.txtQuanPerBox.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                apsf.txtpro_desc.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString();
                apsf.txtBox.Focus();
                apsf.Show();

            }
        }

        private void TxtSearchDelivery_TextChanged(object sender, EventArgs e)
        {
            dgvCustDelivery.DataSource = db.spSearchDelivery(txtSearchDelivery.Text);
        }

        private void TxtSearchReservation_TextChanged(object sender, EventArgs e)
        {
            dgvCustReservation.DataSource = db.spSearchReservation(txtSearchReservation.Text);
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.Header;

            e.Graphics.DrawImage(image, 50, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));

            e.Graphics.DrawString("Customer Name: " + txtcust_name.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------" +
                "------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Product Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Total Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 255));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------" +
                "------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            e.Graphics.DrawString("Total Amount: " + txtAmount.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 300));
            e.Graphics.DrawString("Transact By: " + txtAmount.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 340));
        }

        private void txtQuantityPerBox_TextChanged(object sender, EventArgs e)
        {
            double Quantity = 0.00;
            double Box = 0.00;
            double PerBox = 0.00;
            try
            {
                PerBox = double.Parse(txtQuantityPerBox.Text);
                Quantity = double.Parse(txtpro_quantity.Text);
                Box = Quantity / PerBox;
                lblBox2.Text = Box.ToString();
            }
            catch
            { }
        }

        private void TxtAvailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GbWalkin_Enter(object sender, EventArgs e)
        {
           
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProCode.Text = dgvReservation.CurrentRow.Cells[0].Value.ToString();
            txtpro_name.Text = dgvReservation.CurrentRow.Cells[1].Value.ToString();
            txtpro_price.Text = dgvReservation.CurrentRow.Cells[2].Value.ToString();
            txtpro_quantity.Text = dgvReservation.CurrentRow.Cells[3].Value.ToString();
            lblQuantity.Text = dgvReservation.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgvReservation.CurrentRow.Cells[4].Value.ToString();
            txtcust_name.Text = dgvReservation.CurrentRow.Cells[5].Value.ToString();
            txtcust_address.Text = dgvReservation.CurrentRow.Cells[6].Value.ToString();
            lblTin.Text = dgvReservation.CurrentRow.Cells[7].Value.ToString();
            dtpDateDel.Value = DateTime.Parse(dgvReservation.CurrentRow.Cells[8].Value.ToString());
            cmbTranType.Text = dgvReservation.CurrentRow.Cells[9].Value.ToString();
            lblCustID.Text = dgvReservation.CurrentRow.Cells[11].Value.ToString();
            lblResStatus.Text = dgvReservation.CurrentRow.Cells[13].Value.ToString();
            txtStockOnHand.Text = dgvReservation.CurrentRow.Cells[14].Value.ToString();
            txtQuantityPerBox.Text = dgvReservation.CurrentRow.Cells[15].Value.ToString();
            txtAvailBox.Text = dgvReservation.CurrentRow.Cells[16].Value.ToString();
            lblOrderID.Text = dgvReservation.CurrentRow.Cells[17].Value.ToString();
        }

        private void Txtchange_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpClaimDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PnlProReg_Paint(object sender, PaintEventArgs e)
        {
            RowsColor();
        }
        public void RowsColor()
        {
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                int val = Int32.Parse(dgvProducts.Rows[i].Cells[5].Value.ToString());
                if (val <= 5)
                {
                    dgvProducts.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void PnlStaffMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
