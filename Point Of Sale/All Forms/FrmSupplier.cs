using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Point_Of_Sale.StockForm
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private string editsupplierid = string.Empty;
        private void setcloumnWidth()
        {
            dgv_supplierList.Columns[0].Width = 100;
            dgv_supplierList.Columns[1].Width = 100;
            dgv_supplierList.Columns[2].Width = 100;
            dgv_supplierList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            setcloumnWidth();
            fillgrid("");
        }


        private void txt_contactNO_Leave(object sender, EventArgs e)
        {
            epcategory.Clear();
            if (txt_contactNO.Text.Trim().Length < 13 && txt_contactNO.Text.Trim().Length > 1)
            {
                epcategory.SetError(txt_contactNO, "Please Enter Contact NO");
                txt_contactNO.Focus();
                txt_contactNO.SelectAll();
                return;
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            epcategory.Clear();
            if (txt_SupplierName.Text.Trim().Length == 0)
            {
                epcategory.SetError(txt_SupplierName, "Please Enter Your Name");
                txt_SupplierName.Focus();
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
            string SelectQuery = string.Format("select * from Company Where cumpanyname = '{0}' ", txt_SupplierName.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epcategory.SetError(txt_SupplierName, "Already Exit Name !!");
                txt_SupplierName.Focus();
                return;
            }
            string query = string.Format("insert into Company (cumpanyname ,contactno ,[Description]) values ('{0}' ,'{1}','{2}') ",
            txt_SupplierName.Text.Trim(),  txt_contactNO.Text.Trim(), txt_csupplierDescription.Text.Trim());
            DataBaseLayer.datebase.InsertData(query);
            MessageBox.Show("-----Add company IS SUCCESFULLY--------");
            clearform();
        }

        private void clearform()
        {
            txt_SupplierName.Clear();
            txt_contactNO.Clear();
            txt_csupplierDescription.Clear();
            fillgrid("");
        }
        private void fillgrid(string search)
        {
            DataTable dt = new DataTable();
            dgv_supplierList.Rows.Clear();
            if (search.Trim().Length > 0)
            {
                dt = DataBaseLayer.datebase.Retrivedata("select * from Company where (cumpanyname+Description)='" + search.Trim() + "'" );
            }
            else
            {
                dt = DataBaseLayer.datebase.Retrivedata("Select * from Company");
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow supplier in dt.Rows)
                {
                    dgv_supplierList.Rows.Add(Convert.ToString(supplier[0]), Convert.ToString(supplier[1]), Convert.ToString(supplier[3]) , Convert.ToString(supplier[2]) );
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearform();
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
            editsupplierid = string.Empty;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_supplierList.Rows.Count > 0)
            {
                if (dgv_supplierList.SelectedRows.Count == 1)
                {

                    editsupplierid = Convert.ToString(dgv_supplierList.CurrentRow.Cells[0].Value);
                    txt_contactNO.Text = Convert.ToString(dgv_supplierList.CurrentRow.Cells[2].Value);
                    txt_SupplierName.Text = Convert.ToString(dgv_supplierList.CurrentRow.Cells[1].Value);
                    txt_csupplierDescription.Text = Convert.ToString(dgv_supplierList.CurrentRow.Cells[3].Value);
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

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            DisableComponent();
            clearform();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            epcategory.Clear();
            if (txt_SupplierName.Text.Trim().Length == 0)
            {
                epcategory.SetError(txt_SupplierName, "Please Enter Your Name");
                txt_SupplierName.Focus();
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
            string SelectQuery = string.Format("select * from Company Where cumpanyname = '{0}' and cumpanyID != '{1}' ", 
            txt_SupplierName.Text.Trim() , editsupplierid.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epcategory.SetError(txt_SupplierName, "Already Exit Name !!");
                txt_SupplierName.Focus();
                return;
            }
            string query = string.Format("update Company set cumpanyname= '{0}' ,contactno= '{1}' ,[Description]= '{2}' Where CumpanyID= '{3}'  ",
            txt_SupplierName.Text.Trim(), txt_contactNO.Text.Trim(), txt_csupplierDescription.Text.Trim() , editsupplierid.Trim());
            DataBaseLayer.datebase.InsertData(query);
            MessageBox.Show("-----Update Cumoany IS SUCCESFULLY--------");
            clearform();
            DisableComponent();
        }

        private void txt_supplierSearch_TextChanged(object sender, EventArgs e)
        {
            fillgrid(txt_supplierSearch.Text.Trim());
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_supplierList.Rows.Count > 0)
                {
                    if (dgv_supplierList.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete this category", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string deletequery = string.Format("delete from Company Where CumpanyID = '{0}'", dgv_supplierList.CurrentRow.Cells[0].Value);
                            DataBaseLayer.datebase.DeleteData(deletequery);
                            MessageBox.Show(".....Cumapny Delete Is Succesfull...");
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
        }
    }
}