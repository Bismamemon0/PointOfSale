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

using Point_Of_Sale.DataBaseLayer;

namespace Point_Of_Sale.All_Forms
{
    public partial class formProducts : Form
    {
        public formProducts()
        {
            InitializeComponent();
        }

        private string updateProductID = string.Empty;
        
        private void formProducts_Load(object sender, EventArgs e)
        {
            comboboxlist.Categorylist(comboBox_selectProduct);
            setcloumnWidth();
            cmb_Quality.SelectedIndex = 2;
            fillgrid("");
        }

        private void setcloumnWidth()
        {
            dgv_product.Columns[0].Width = 100;
            dgv_product.Columns[1].Width = 100;
            dgv_product.Columns[2].Width = 130;
            dgv_product.Columns[3].Width = 100;
            dgv_product.Columns[4].Width = 100;
            dgv_product.Columns[5].Width = 100;
            dgv_product.Columns[6].Width = 100;
            dgv_product.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void formclear()
        {
            txt_productName.Clear();
            txt_Quantity.Clear();
            txt_ProductDescription.Clear();
            txt_UnitPrice.Clear();
            cmb_Quality.SelectedIndex = 2;
            txt_cProductSearch.Clear();
            fillgrid("");
        }

        private void EnableComponent()
        {
            btn_update.Enabled = true;
            btn_cancle.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = false;
            btn_clear.Enabled = false;

        }
        private void DisableComponent()
        {
            btn_update.Enabled = false;
            btn_cancle.Enabled = false;
            btn_save.Enabled = true;
            btn_edit.Enabled = true;
            btn_clear.Enabled = true;
            formclear();
        }

        private void fillgrid(string search)
        {
            dgv_product.Rows.Clear();
            DataTable dt = new DataTable();
            if (search.Trim().Length > 0)
            {
                string query = "select * from view_stocklist where (productname + name) like '%" + search + "%'";
                dt = DataBaseLayer.datebase.Retrivedata(query);
            }
            else
            {
                string querys = "Select * from view_stocklist";
                dt = DataBaseLayer.datebase.Retrivedata(querys);
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    dgv_product.Rows.Add (Convert.ToString(item[2]), Convert.ToString(item[1]), Convert.ToString(item[3])
                   , Convert.ToInt32(item[4]), Convert.ToInt32(item[5]),
                   (Convert.ToDecimal(Convert.ToString(item[4]))) * Convert.ToInt32( Convert.ToString(item[5])),
                    Convert.ToString(item[6]), Convert.ToString(item[7]));
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ep_product.Clear();
            if (comboBox_selectProduct.SelectedIndex < 1)
            {
                ep_product.SetError(comboBox_selectProduct, "Please select category");
                comboBox_selectProduct.Focus();
                return;
            }
            if (txt_productName.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_productName, "Please Enter Product Name !!!");
                txt_productName.Focus();
                return;
            }
            if (txt_UnitPrice.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_UnitPrice, "Please Enter Unit Price !!!");
                txt_UnitPrice.Focus();
                return;
            }
            if (txt_Quantity.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_Quantity, "Please Enter Quantity !!!");
                txt_Quantity.Focus();
                return;
            }
            if (cmb_Quality.SelectedIndex == 0)
            {
                ep_product.SetError(cmb_Quality, "Please Enter Quality !!!");
                cmb_Quality.Focus();
                return;
            }

            string categoryID = string.Empty;
            DataTable dt = new DataTable();
            string selectquery = string.Format("select * from Categories where Name= '{0}' ", comboBox_selectProduct.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(selectquery);
            categoryID = Convert.ToString(dt.Rows[0][0]);

            string insertproduct = string.Format("insert into Products (CategoryID,categoryname,productName ,UnitPrice,Quantity,Quality,[Description]) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            categoryID.Trim(),comboBox_selectProduct.Text.Trim(),txt_productName.Text.Trim(), txt_UnitPrice.Text.Trim()
            , txt_Quantity.Text.Trim()  , cmb_Quality.Text.Trim(), txt_ProductDescription.Text.Trim() );
            DataBaseLayer.datebase.InsertData(insertproduct);
            MessageBox.Show("insert Product Is successfull");
            fillgrid("");
            formclear();
        }

        private void txt_cProductSearch_TextChanged(object sender, EventArgs e)
        {
            fillgrid(txt_cProductSearch.Text.Trim());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            formclear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_product.Rows.Count > 0)
            {
                if (dgv_product.SelectedRows.Count == 1)
                {
                    updateProductID =Convert.ToString( dgv_product.CurrentRow.Cells[0].Value);
                    txt_productName.Text = Convert.ToString(dgv_product.CurrentRow.Cells[1].Value);
                    comboBox_selectProduct.Text = Convert.ToString(dgv_product.CurrentRow.Cells[2].Value);
                    txt_UnitPrice.Text = Convert.ToString(dgv_product.CurrentRow.Cells[3].Value);
                    txt_Quantity.Text = Convert.ToString(dgv_product.CurrentRow.Cells[4].Value);
                    cmb_Quality.Text = Convert.ToString(dgv_product.CurrentRow.Cells[6].Value);
                    txt_ProductDescription.Text = Convert.ToString(dgv_product.CurrentRow.Cells[7].Value);
                    EnableComponent();
                    return;

                }
                else
                {
                    MessageBox.Show("Please Select One Record!!`");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Stock is empty");
            }
        }

        private void comboBox_selectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            updateProductID = string.Empty;
            formclear();
            EnableComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ep_product.Clear();
            if (comboBox_selectProduct.SelectedIndex < 1)
            {
                ep_product.SetError(comboBox_selectProduct, "Please select category");
                comboBox_selectProduct.Focus();
                return;
            }
            if (txt_productName.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_productName, "Please Enter Product Name !!!");
                txt_productName.Focus();
                return;
            }
            if (txt_UnitPrice.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_UnitPrice, "Please Enter Unit Price !!!");
                txt_UnitPrice.Focus();
                return;
            }
            if (txt_Quantity.Text.Trim().Length == 0)
            {
                ep_product.SetError(txt_Quantity, "Please Enter Quantity !!!");
                txt_Quantity.Focus();
                return;
            }
            if (cmb_Quality.SelectedIndex == 0)
            {
                ep_product.SetError(cmb_Quality, "Please Enter Quality !!!");
                cmb_Quality.Focus();
                return;
            }

            DataTable checkproduct = new DataTable();
            string querty = string.Format("select * from view_stocklist where productname= '{0}' and categoryname= '{1}' and productID !='{2}' " , txt_productName.Text.Trim() , comboBox_selectProduct.Text.Trim() , updateProductID.Trim());
            checkproduct = DataBaseLayer.datebase.Retrivedata(querty);
            if (checkproduct.Rows.Count > 0)
            {
                ep_product.SetError(txt_productName, "Product Name Already Exits");
                txt_productName.Focus();
                return;
            }
            fillgrid("");
            string categoryID = string.Empty;
            DataTable dt = new DataTable();
            string selectquery = string.Format("select CategoryID from categories where name = '{0}' ", comboBox_selectProduct.Text);
            dt = DataBaseLayer.datebase.Retrivedata(selectquery);
            categoryID = Convert.ToString(dt.Rows[0][0]);

            string insertproduct = string.Format("update Products set CategoryID= '{0}',categoryname= '{1}', productname= '{2}', UnitPrice= '{3}', Quantity= '{4}', Quality= '{5}', [Description]= '{6}'  Where productid = '{7}' ",
            categoryID,comboBox_selectProduct.Text.Trim(), txt_productName.Text.Trim(), txt_UnitPrice.Text.Trim(),
            txt_Quantity.Text.Trim() , cmb_Quality.Text.Trim(), txt_ProductDescription.Text.Trim(), updateProductID.Trim());
            DataBaseLayer.datebase.InsertData(insertproduct);
            MessageBox.Show("Pruduct Update is successfull");
            fillgrid("");
            formclear();
            DisableComponent();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_product.Rows.Count > 0)
                {
                    if (dgv_product.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete this category", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string deletequery = string.Format("delete from Products Where categoryid = '{0}'", dgv_product.CurrentRow.Cells[0].Value);
                            DataBaseLayer.datebase.DeleteData(deletequery);
                            MessageBox.Show(".....product Delete Is Succesfull...");
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

        private void txt_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
