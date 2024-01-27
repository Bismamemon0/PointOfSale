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
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();
        }

        private string EditCategoryID = string.Empty;

        private void setcloumnWidth()
        {
            dgv_categoryList.Columns[0].Width = 100;
            dgv_categoryList.Columns[1].Width = 100;
            dgv_categoryList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void fillgrid(string search)
        {
            DataTable dt = new DataTable();
            dgv_categoryList.Rows.Clear();
            if (search.Trim().Length > 0)
            {
                dt = DataBaseLayer.datebase.Retrivedata("select * from Categories where (Name+Description) like '%" + search + "%'");
            }
            else
            {
                dt = DataBaseLayer.datebase.Retrivedata("Select * from Categories");
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow category in dt.Rows)
                {
                    dgv_categoryList.Rows.Add(Convert.ToString(category[0]), Convert.ToString(category[1]), Convert.ToString(category[2]));
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            epcategory.Clear();
            if (txt_categoryName.Text.Trim().Length == 0)
            {
                epcategory.SetError(txt_categoryName, "Please Enter Category Name !!");
                txt_categoryName.Focus();
                txt_categoryName.SelectAll();
                return;
            }
            DataTable dt = new DataTable();
            string SelectQuery = string.Format("select * from Categories Where name ='{0}' ", txt_categoryName.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epcategory.SetError(txt_categoryName, "Please Enter Category Name !!");
                txt_categoryName.Focus();
                txt_categoryName.SelectAll();
                return;
            }
            string query = string.Format("insert into Categories(name ,[Description]) values ('{0}' ,'{1}')"
            , txt_categoryName.Text, txt_categoryDescription.Text);
            DataBaseLayer.datebase.InsertData(query);
            clearform();
            MessageBox.Show("-----Add Category IS SUCCESFULLY--------");
        }
        public void clearform()
        {
            txt_categoryName.Clear();
            txt_categoryDescription.Clear();
            fillgrid(string.Empty);
        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            fillgrid(string.Empty);
            setcloumnWidth();
        }

        private void txt_categorySearch_TextChanged(object sender, EventArgs e)
        {
            fillgrid(txt_categorySearch.Text);
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
            EditCategoryID = string.Empty;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_categoryList.Rows.Count > 0)
            {
                if (dgv_categoryList.SelectedRows.Count == 1)
                {

                    EditCategoryID = Convert.ToString(dgv_categoryList.CurrentRow.Cells[0].Value);
                    txt_categoryName.Text = Convert.ToString(dgv_categoryList.CurrentRow.Cells[1].Value);
                    txt_categoryDescription.Text = Convert.ToString(dgv_categoryList.CurrentRow.Cells[2].Value);
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
            clearform();
            DisableComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            epcategory.Clear();
            if (txt_categoryName.Text.Trim().Length == 0)
            {
                epcategory.SetError(txt_categoryName, "Please Enter Category Name !!");
                txt_categoryName.Focus();
                txt_categoryName.SelectAll();
                return;
            }

            DataTable dt = new DataTable();
            string SelectQuery = string.Format("select * from Categories Where name='{0}' and CategoryID!='{1}' ", txt_categoryName.Text.Trim(), EditCategoryID.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(SelectQuery);
            if (dt.Rows.Count > 0)
            {
                epcategory.SetError(txt_categoryName, "Please Enter Category Name !!");
                txt_categoryName.Focus();
                txt_categoryName.SelectAll();
                return;
            }
                string query = string.Format("update Categories set NAME = '{0}' [description]='{1}' Where CategoryID ='{2}' ", txt_categoryName.Text.Trim(), txt_categoryDescription.Text.Trim(), EditCategoryID.Trim());
                DataBaseLayer.datebase.InsertData(query);
                clearform();
                MessageBox.Show("-----Add Category IS SUCCESFULLY--------");

            
                DisableComponent();
            }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_categoryList.Rows.Count > 0)
            {
                if (dgv_categoryList.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete this category", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = string.Format("select * from Products Where CategoryID  = '{0}' ", dgv_categoryList.CurrentRow.Cells[0].Value);
                        DataTable dt = new DataTable();
                        dt = DataBaseLayer.datebase.Retrivedata(query);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Only Empty Category Is Deleted......");
                            return;
                        }
                        string deletequery = string.Format("delete from Categories Where CategoryID = '{0}'", dgv_categoryList.CurrentRow.Cells[0].Value);
                        DataBaseLayer.datebase.DeleteData(deletequery);
                        MessageBox.Show("...ategory Delete Is Succesfull...");
                        fillgrid("");
                        return;

                    }
                }
                else
                {

                    MessageBox.Show("Only Empty Category Is Deleted......");
                    return;
                }
            }
            else
            {
                MessageBox.Show("List is Empty");
            }
        }

        private void dgv_categoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
