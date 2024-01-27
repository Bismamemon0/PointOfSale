using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale.All_Forms
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        private string editCustomerID = string.Empty;
        private void setcloumnWidth()
        {
            dgv_customerList.Columns[0].Width = 100;
            dgv_customerList.Columns[1].Width = 100;
            dgv_customerList.Columns[2].Width = 100;
            dgv_customerList.Columns[3].Width = 100;
            dgv_customerList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            setcloumnWidth();
            fillgrid("");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            epCustomer.Clear();
            if (txt_CustomerName.Text.Trim().Length == 0)
            {
                epCustomer.SetError(txt_CustomerName, "Please Enter Your Name");
                txt_CustomerName.Focus();
                return;
            }
            string contactno = string.Empty;
            if (txt_contactNO.Text.Length == 1)
            {
                contactno = "";
            }
            else
            {
                contactno = txt_contactNO.Text.Trim();
            }
            DataTable dt = new DataTable();
            string SelectQuery = string.Format("select * from Customer Where CustomerNmae = '{0}' ", txt_CustomerName.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epCustomer.SetError(txt_CustomerName, "Already Exit Name !!");
                txt_CustomerName.Focus();
                return;
            }
            string query = string.Format("insert into Customer ( CustomerNmae ,Address,contactno,[Description]) values ('{0}' ,'{1}','{2}','{3}') ",
             txt_CustomerName.Text.Trim(), txt_address.Text.Trim(), txt_contactNO.Text.Trim(), txt_cCustomerDescription.Text.Trim());
            DataBaseLayer.datebase.InsertData(query);
            MessageBox.Show("-----Add Customer IS SUCCESFULLY--------");
            clearform();
            fillgrid("");
        }

        private void clearform()
        {
            txt_CustomerName.Clear();
            txt_contactNO.Clear();
            txt_cCustomerDescription.Clear();
            txt_address.Clear();
            txt_cCustomerDescription.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearform();
            fillgrid("");
        }
        private void fillgrid(string search)
        {
            DataTable dt = new DataTable();
            dgv_customerList.Rows.Clear();
            if (search.Trim().Length > 0)
            {
                dt = DataBaseLayer.datebase.Retrivedata("select * from Customer where (CustomerNmae+Description)='" + search.Trim() + "'");
            }
            else
            {
                dt = DataBaseLayer.datebase.Retrivedata("Select * from Customer");
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow supplier in dt.Rows)
                {
                    dgv_customerList.Rows.Add(Convert.ToString(supplier[0]), Convert.ToString(supplier[1]), Convert.ToString(supplier[4]), Convert.ToString(supplier[2]), Convert.ToString(supplier[3]));
                }
            }
        }

        private void EnableComponent()
        {
            btn_update.Enabled = true;
            btn_cancle.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = false;

        }
        private void DisableComponent()
        {
            btn_update.Enabled = false;
            btn_cancle.Enabled = false;
            btn_save.Enabled = true;
            btn_edit.Enabled = true;

        }


        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            if (dgv_customerList.Rows.Count > 0)
            {
                if (dgv_customerList.SelectedRows.Count == 1)
                {

                    editCustomerID = Convert.ToString(dgv_customerList.CurrentRow.Cells[0].Value);
                    txt_contactNO.Text = Convert.ToString(dgv_customerList.CurrentRow.Cells[2].Value);
                    txt_CustomerName.Text = Convert.ToString(dgv_customerList.CurrentRow.Cells[1].Value);
                    txt_cCustomerDescription.Text = Convert.ToString(dgv_customerList.CurrentRow.Cells[4].Value);
                    txt_address.Text = Convert.ToString(dgv_customerList.CurrentRow.Cells[3].Value);
                    EnableComponent();
                }
                else
                {
                    MessageBox.Show("Please Select One Record!!`");
                    return;
                }
            }
            else
            {
                MessageBox.Show("List is empty");
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {

            epCustomer.Clear();
            if (txt_CustomerName.Text.Trim().Length == 0)
            {
                epCustomer.SetError(txt_CustomerName, "Please Enter Your Name");
                txt_CustomerName.Focus();
                return;
            }
            string contactno = string.Empty;
            if (txt_contactNO.Text.Length == 1)
            {
                contactno = "";
            }
            else
            {
                contactno = txt_contactNO.Text.Trim();
            }
            DataTable dt = new DataTable();
            string SelectQuery = string.Format("select * from Customer Where CustomerNmae = '{0}' and customerID != '{1}' ",
           txt_CustomerName.Text.Trim(), editCustomerID.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epCustomer.SetError(txt_CustomerName, "Already Exit Name !!");
                txt_CustomerName.Focus();
                return;
            }
            string query = string.Format("update Customer set CustomerNmae= '{0}',Address= '{1}' ,contactno= '{2}' ,[Description]= '{3}' Where CustomerID= '{4}'  ",
            txt_CustomerName.Text.Trim(), txt_address.Text.Trim(), txt_contactNO.Text.Trim(), txt_cCustomerDescription.Text.Trim(), editCustomerID.Trim());
            DataBaseLayer.datebase.InsertData(query);
            MessageBox.Show("-----Update Cumoany IS SUCCESFULLY--------");
            clearform();
            DisableComponent();
            fillgrid("");
        }

        private void txt_scustomerSearch_TextChanged(object sender, EventArgs e)
        {
            fillgrid(txt_scustomerSearch.Text.Trim());
        }

        private void txt_contactNO_Leave(object sender, EventArgs e)
        {
            epCustomer.Clear();
            if (txt_contactNO.Text.Trim().Length < 13 && txt_contactNO.Text.Trim().Length > 1)
            {
                epCustomer.SetError(txt_contactNO, "Please Enter Contact NO");
                txt_contactNO.Focus();
                txt_contactNO.SelectAll();
                return;
            }
        }

        private void btn_cancle_Click_1(object sender, EventArgs e)
        {
            DisableComponent();
            clearform();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_customerList.Rows.Count > 0)
                {
                    if (dgv_customerList.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete this customer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string deletequery = string.Format("delete from Customer Where customerID = '{0}'", dgv_customerList.CurrentRow.Cells[0].Value);
                            DataBaseLayer.datebase.DeleteData(deletequery);
                            MessageBox.Show(".....Customer Delete Is Succesfull...");
                            fillgrid("");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("List is empty");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("some record are depended on selected record !!!");
            }
            fillgrid("");
        }
    }
}
