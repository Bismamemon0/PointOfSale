using Point_Of_Sale.DataBaseLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Point_Of_Sale.All_Forms
{
    public partial class NewPurchase : Form
    {
        public NewPurchase()
        {
            InitializeComponent();
        }

        private string supplierID = string.Empty;

        private void SetColumnWidth()
        {
            dgv_category.Columns[0].Width = 0;
            dgv_category.Columns[1].Width = 0;
            dgv_category.Columns[2].Width = 140;
            dgv_category.Columns[3].Width = 100;
            dgv_category.Columns[4].Width = 100;
            dgv_category.Columns[5].Width = 140;
            dgv_category.Columns[6].Width = 170;
            dgv_category.Columns[7].Width = 180;
            dgv_category.Columns[8].Width = 140;
        }

        public object comboxlist { get; private set; }

        private void ClearSearchCheckBox()
        {
            lblName.Text = string.Empty;
            lbl_CDontactno.Text = string.Empty;
            lbl_Description.Text = string.Empty;
            supplierID = string.Empty;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ep_Purchase.Clear();
            ClearSearchCheckBox();
            if (txt_searchSupplier.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_searchSupplier, "Please Enter Supplier Name./ContactNO With Country Code e.g(+92)");
                txt_searchSupplier.Focus();
                return;
            }
            DataTable dt = new DataTable();
            string query = string.Format("select * from Company Where cumpanyname = '{0}' ", txt_searchSupplier.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(query);
            if (dt.Rows.Count == 0)
            {
                string querys = string.Format("select * from Company Where ContactNO = '{0}' ", txt_searchSupplier.Text.Trim());
                dt = DataBaseLayer.datebase.Retrivedata(querys);
            }
            if (dt.Rows.Count > 0)
            {
                supplierID = Convert.ToString(dt.Rows[0]["cumpanyid"]);
                lblName.Text = Convert.ToString(dt.Rows[0]["cumpanyname"]);
                lbl_CDontactno.Text = Convert.ToString(dt.Rows[0]["contactno"]);
                lbl_Description.Text = Convert.ToString(dt.Rows[0]["description"]);
                SlectedSupplierPurchase();
            }
            else
            {
                ClearSearchCheckBox();
                MessageBox.Show("Record Not Found");
            }
        }
        private void NewPurchases()
        {
            grpCategory.Enabled = false;
            grpPurchaseINformation.Enabled = false;
            grpProductInformation.Enabled = false;
            grpProduct.Enabled = false;
            btnFinilize.Enabled = false;
            btnClears.Enabled = false;
            clearAddGroup();
            dgv_category.Rows.Clear();
            supplierID = string.Empty;
            ClearSearchCheckBox();
            txt_searchSupplier.Clear();
        }
        private void SlectedSupplierPurchase()
        {
            grpCategory.Enabled = true;
            grpPurchaseINformation.Enabled = true;
            grpProductInformation.Enabled = true;
            grpProduct.Enabled = true;
            btnFinilize.Enabled = true;
            btnClears.Enabled = true;
        }
        private void NewPurchase_Load(object sender, EventArgs e)
        {
            NewPurchases();
            comboboxlist.Categorylist(cmb_SelectCategory);
            SetColumnWidth();
            cmb_ProductQuality.SelectedIndex = 2;
        }
          private string categoryid = string.Empty;

        private void cmb_SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SelectCategory.SelectedIndex > 0)
            {
                string query = string.Format("select * from Categories Where name= '{0}' ", cmb_SelectCategory.Text.Trim());
                categoryid = Convert.ToString(DataBaseLayer.datebase.Retrivedata(query).Rows[0][0]);
                comboboxlist.productlist(cmb_SelectProduct, categoryid);
            }
            else
            {
                categoryid = string.Empty;
                cmb_SelectProduct.Items.Clear();
            }
        }

        private void cmb_SelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SelectProduct.SelectedIndex > 0)
            {
                DataTable dt = new DataTable();
                string productnames = cmb_SelectProduct.Text.Trim();
                int indexofbr = productnames.IndexOf("(");
                productnames = productnames.Substring(0, indexofbr).Trim();

                string proQuality = cmb_SelectProduct.Text.Trim();
                int indexstart = proQuality.IndexOf("(");
                int indexend = proQuality.IndexOf(")");
                proQuality = proQuality.Substring((indexstart + 1));
                proQuality = proQuality.Substring(0, (proQuality.Length - 1));
                
                string query = string.Format("select top 1 * from Products Where productName= '{0}' and categoryid= {1} ", productnames, categoryid);
                dt = DataBaseLayer.datebase.Retrivedata(query);
                if (dt.Rows.Count > 0)
                {
                    cmb_ProductQuality.Text = Convert.ToString(dt.Rows[0]["Quality"]);
                    lblProductName.Text = Convert.ToString(dt.Rows[0]["productName"]);
                    lvlSoldQuantity.Text = Convert.ToString(dt.Rows[0]["Quantity"]);
                    lblProductUnitPrice.Text = Convert.ToString(dt.Rows[0]["UnitPrice"]);
                    lblQuality.Text = Convert.ToString(dt.Rows[0]["Quality"]);

                }
                else
                {
                    cmb_ProductQuality.SelectedIndex = 2;
                    lblProductName.Text = "";
                    lblQuality.Text = "";
                    lvlSoldQuantity.Text = "";
                    lblProductUnitPrice.Text = "";
                }
            }
            else
            {
                cmb_ProductQuality.SelectedIndex = 2;
                lblProductName.Text = "";
                lvlSoldQuantity.Text = "";
                lblQuality.Text = "";
                lblProductUnitPrice.Text = "";
            }
        }

        private void cmb_ProductQuality_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ep_Purchase.Clear();
            if (cmb_ProductQuality.Text.Trim() == lblQuality.Text.Trim())
            {
                return;
            }
            if (int.Parse(lvlSoldQuantity.Text) > 0)
            {
                ep_Purchase.SetError(cmb_ProductQuality, "Already Some Product are avalible in stock \n " +
                "select product sold Quantity Must be Zero If you want change quality of a product");
                cmb_ProductQuality.Focus();
                cmb_ProductQuality.Text = lblQuality.Text;
                return;
            }
        }

        private void txt_PurchaseQuatity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_PurchaseUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtSellUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_PurchaseQuatity_TextChanged(object sender, EventArgs e)
        {
            if (txt_PurchaseQuatity.Text.Trim().Length > 0 && txt_PurchaseUnitPrice.Text.Trim().Length > 0)
            {
                int PQuantity = 0;
                int PUmitPrice = 0;
                PQuantity = int.Parse(txt_PurchaseQuatity.Text.Trim());
                PUmitPrice = int.Parse(txt_PurchaseUnitPrice.Text.Trim());
                txt_ItemCost.Text = Convert.ToString(PQuantity * PUmitPrice);
            }
            else
            {
                txt_ItemCost.Text = "0";
            }
        }

        private void txt_PurchaseUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (txt_PurchaseQuatity.Text.Trim().Length > 0 && txt_PurchaseUnitPrice.Text.Trim().Length > 0)
            {
                int PQuantity = 0;
                int PUmitPrice = 0;
                PQuantity = int.Parse(txt_PurchaseQuatity.Text.Trim());
                PUmitPrice = int.Parse(txt_PurchaseUnitPrice.Text.Trim());
                txt_ItemCost.Text = Convert.ToString(PQuantity * PUmitPrice);
            }
            else
            {
                txt_ItemCost.Text = "0";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ep_Purchase.Clear();
            if (cmb_SelectCategory.SelectedIndex == 0)
            {
                ep_Purchase.SetError(cmb_SelectCategory, "Please select category");
                cmb_SelectCategory.Focus();
                return;
            }
            if (cmb_SelectProduct.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(cmb_SelectProduct, "Please Enter Product Name !!!");
                cmb_SelectProduct.Focus();
                return;
            }
            if (cmb_ProductQuality.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(cmb_ProductQuality, "Please Enter Product Quantity !!!");
                cmb_ProductQuality.Focus();
                return;
            }
            if (txt_PurchaseQuatity.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_PurchaseQuatity, "Please Quantity  !!!");
                txt_PurchaseQuatity.Focus();
                return;
            }
            if (txt_PurchaseUnitPrice.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_PurchaseUnitPrice, "Please Enter Purchase Unit Price !!!");
                txt_PurchaseUnitPrice.Focus();
                return;
            }
            if (txtSellUnitPrice.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txtSellUnitPrice, "Please Enter Sell Unit Price !!!");
                txtSellUnitPrice.Focus();
                return;
            }
            if (txt_ItemCost.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_ItemCost, "Please Enter Item Cost !!!");
                txt_ItemCost.Focus();
                return;
            }
            if (int.Parse(txt_ItemCost.Text.Trim()) == 0)
            {
                ep_Purchase.SetError(txt_ItemCost, "Please Enter Parchase Quantity and Unit Price Of Purchase Product !!!");
                txt_ItemCost.Focus();
                return;
            }

            if (dgv_category.Rows.Count > 0)
            {
                foreach (DataGridViewRow product in dgv_category.Rows)
                {
                    if ((cmb_SelectProduct.Text.Trim() == Convert.ToString(product.Cells[2].Value).Trim())
                    && (cmb_SelectProduct.Text.Trim() == Convert.ToString(product.Cells[3].Value).Trim())
                    && (cmb_ProductQuality.Text.Trim() == Convert.ToString(product.Cells[4].Value).Trim()))
                    {
                        ep_Purchase.SetError(cmb_SelectProduct, "Already Is Product Xategory");
                        cmb_SelectProduct.Focus();
                        product.Selected = true;
                        return;
                    }
                }
            }

            string productId = string.Empty;
            string CategoryID = string.Empty;
            DataTable dt = new DataTable();
            string query = string.Format("select top 1 CategoryID from categories where name= '{0}' ", cmb_SelectCategory.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(query);
            if (dt.Rows.Count > 0)
            {
                CategoryID = dt.Rows[0]["CategoryID"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Please Restart The Application");
                return;
            }

            DataTable dt1 = new DataTable();
            string productnames = cmb_SelectProduct.Text.Trim();
            int indexofbr = productnames.IndexOf("(");
            productnames = productnames.Substring(0, indexofbr).Trim();

            string proQuality = cmb_SelectProduct.Text.Trim();
            int indexstart = proQuality.IndexOf("(");
            int indexend = proQuality.IndexOf(")");
            proQuality = proQuality.Substring((indexstart + 1));
            proQuality = proQuality.Substring(0, (proQuality.Length - 1));


            string querys = string.Format("select top 1 ProductID from Products where productName= '{0}' and categoryID= '{1}' "
            , productnames.Trim(), CategoryID);
            dt1 = DataBaseLayer.datebase.Retrivedata(querys);
            if (dt1.Rows.Count > 0)
            {
                productId = dt1.Rows[0][0].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Please Restart The Application");
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_category);
            row.Cells[0].Value = productId;
            row.Cells[1].Value = CategoryID;
            row.Cells[2].Value = cmb_SelectProduct.Text.Trim();
            row.Cells[3].Value = cmb_SelectCategory.Text.Trim();
            row.Cells[4].Value = cmb_ProductQuality.Text.Trim();
            row.Cells[5].Value = txtSellUnitPrice.Text.Trim();
            row.Cells[6].Value = txt_PurchaseQuatity.Text.Trim();
            row.Cells[7].Value = txt_PurchaseUnitPrice.Text.Trim();
            row.Cells[8].Value = txt_ItemCost.Text.Trim();
            dgv_category.Rows.Add(row);
            clearAddGroup();
            lblTotalAmount.Text =Convert.ToString(CalculateAmount());
        }

        private int CalculateAmount()
        {
            int Calculate = 0;
            for (int i = 0; i < dgv_category.Rows.Count; i++)
            {
                Calculate += Convert.ToInt32(dgv_category.Rows[i].Cells[8].Value);
            }
            return Calculate;
        }

        private void clearAddGroup()
        {
            cmb_ProductQuality.SelectedIndex = 0;
            txt_PurchaseQuatity.Clear();
            txt_PurchaseUnitPrice.Clear();
            txtSellUnitPrice.Clear();
            txt_ItemCost.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAddGroup();
        }
        private void linkLbl_EditProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv_category.Rows.Count > 0)
            {
                if (dgv_category.SelectedRows.Count == 1)
                {
                    cmb_SelectCategory.Text = Convert.ToString(dgv_category.CurrentRow.Cells[3].Value);
                    cmb_SelectProduct.Text = Convert.ToString(dgv_category.CurrentRow.Cells[2].Value);
                    cmb_ProductQuality.Text = Convert.ToString(dgv_category.CurrentRow.Cells[4].Value);
                    txtSellUnitPrice.Text = Convert.ToString(dgv_category.CurrentRow.Cells[5].Value);
                    txt_PurchaseQuatity.Text = Convert.ToString(dgv_category.CurrentRow.Cells[6].Value);
                    txt_PurchaseUnitPrice.Text = Convert.ToString(dgv_category.CurrentRow.Cells[7].Value);
                    txt_ItemCost.Text = Convert.ToString(dgv_category.CurrentRow.Cells[8].Value);

                }
                else
                {
                    MessageBox.Show("Please Select One Record");
                    return;

                }
            }
            else
            {
                MessageBox.Show("Parchase Card Is Empty");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep_Purchase.Clear();
            if (cmb_SelectCategory.SelectedIndex == 0)
            {
                ep_Purchase.SetError(cmb_SelectCategory, "Please select category");
                cmb_SelectCategory.Focus();
                return;
            }
            if (cmb_SelectProduct.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(cmb_SelectProduct, "Please Enter Product Name !!!");
                cmb_SelectProduct.Focus();
                return;
            }
            if (cmb_ProductQuality.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(cmb_ProductQuality, "Please Enter Product Quantity !!!");
                cmb_ProductQuality.Focus();
                return;
            }
            if (txt_PurchaseQuatity.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_PurchaseQuatity, "Please Quantity  !!!");
                txt_PurchaseQuatity.Focus();
                return;
            }
            if (txt_PurchaseUnitPrice.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_PurchaseUnitPrice, "Please Enter Purchase Unit Price !!!");
                txt_PurchaseUnitPrice.Focus();
                return;
            }
            if (txtSellUnitPrice.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txtSellUnitPrice, "Please Enter Sell Unit Price !!!");
                txtSellUnitPrice.Focus();
                return;
            }
            if (txt_ItemCost.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_ItemCost, "Please Enter Item Cost !!!");
                txt_ItemCost.Focus();
                return;
            }
            if (int.Parse(txt_ItemCost.Text.Trim()) == 0)
            {
                ep_Purchase.SetError(txt_ItemCost, "Please Enter Parchase Quantity and Unit Price Of Purchase Product !!!");
                txt_ItemCost.Focus();
                return;
            }

            if (dgv_category.Rows.Count > 0)
            {
                int indexrow = dgv_category.CurrentRow.Index;
                foreach (DataGridViewRow product in dgv_category.Rows)
                {
                    if (indexrow != product.Index)
                    {
                        if ((cmb_SelectProduct.Text.Trim() == Convert.ToString(product.Cells[2].Value).Trim())
                    && (cmb_SelectProduct.Text.Trim() == Convert.ToString(product.Cells[3].Value).Trim())
                    && (cmb_ProductQuality.Text.Trim() == Convert.ToString(product.Cells[4].Value).Trim()))
                        {
                            ep_Purchase.SetError(cmb_SelectProduct, "Already Is Product Xategory");
                            cmb_SelectProduct.Focus();
                            product.Selected = true;
                            return;
                        }
                    }
                }
            }

            string productId = string.Empty;
            string CategoryID = string.Empty;
            DataTable dt = new DataTable();
            string query = string.Format("select top 1 CategoryID from categories where name= '{0}' ", cmb_SelectCategory.Text.Trim());
            dt = DataBaseLayer.datebase.Retrivedata(query);
            if (dt.Rows.Count > 0)
            {
                CategoryID = dt.Rows[0]["CategoryID"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Please Restart The Application");
                return;
            }

            DataTable dt1 = new DataTable();
            string productnames = cmb_SelectProduct.Text.Trim();
            int indexofbr = productnames.IndexOf("(");
            productnames = productnames.Substring(0, indexofbr).Trim();

            string querys = string.Format("select top 1 ProductID from Products where productName= '{0}' and categoryID= '{1}' "
            , productnames.Trim(), CategoryID);
            dt1 = DataBaseLayer.datebase.Retrivedata(querys);
            if (dt1.Rows.Count > 0)
            {
                productId = dt.Rows[0][0].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Please Restart The Application");
                return;
            }
            dgv_category.CurrentRow.Cells[0].Value = productId;
            dgv_category.CurrentRow.Cells[1].Value = CategoryID;
            dgv_category.CurrentRow.Cells[2].Value = cmb_SelectProduct.Text.Trim();
            dgv_category.CurrentRow.Cells[3].Value = cmb_SelectCategory.Text.Trim();
            dgv_category.CurrentRow.Cells[4].Value = cmb_ProductQuality.Text.Trim();
            dgv_category.CurrentRow.Cells[5].Value = txtSellUnitPrice.Text.Trim();
            dgv_category.CurrentRow.Cells[6].Value = txt_PurchaseQuatity.Text.Trim();
            dgv_category.CurrentRow.Cells[7].Value = txt_PurchaseUnitPrice.Text.Trim();
            dgv_category.CurrentRow.Cells[8].Value = txt_ItemCost.Text.Trim();
            clearAddGroup();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void linkLbl_DeleteProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv_category.Rows.Count > 0)
            {
                if (dgv_category.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete Slected Product From Purchase Cat ...", "Conformatiom",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgv_category.Rows.Remove(dgv_category.CurrentRow);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select One Record");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Parchase Card Is Empty");
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            clearAddGroup();
        }
        private void btnCancles_Click(object sender, EventArgs e)
        {
            NewPurchases();
        }

        private void btnFinilize_Click(object sender, EventArgs e)
        {
            ep_Purchase.Clear();
            if (lblName.Text.Trim().Length == 0)
            {
                ep_Purchase.SetError(txt_searchSupplier, "Please Search Supplier");
                txt_searchSupplier.Focus();
                return;
            }
            if (dgv_category.Rows.Count == 0)
            {
                MessageBox.Show("Purchase Cat Is Empty");
                return;
            }
            if (dgv_category.Rows.Count > 0)
            {
                int purchaseID = 0;
                string query = string.Format("insert into Purchase (CompanyID,Purchasedate,TotalAmount,Desvription) values ('{0}' , '{1}','{2}','{3}')", supplierID.Trim(), dtp_purchaseDate.Value.ToString("yyyy/MM/dd"),lblTotalAmount.Text.Trim(),txt_purchaseDescription.Text.Trim());
                DataBaseLayer.datebase.InsertData(query);
                DataTable dt = new DataTable();
                string querys = string.Format("select max(purchaseID) from Purchase Where companyID= '{0}' and TotalAmount= '{1}'", supplierID,lblTotalAmount.Text.Trim());
                dt = DataBaseLayer.datebase.Retrivedata(querys);
                if (dt.Rows.Count > 0)
                {
                    purchaseID =int.Parse(Convert.ToString(dt.Rows[0][0]).Trim());
                }
                else
                {
                    MessageBox.Show("Please Restart The Application");
                    return;
                }

                foreach (DataGridViewRow product in dgv_category.Rows)
                {
                    string productnames = Convert.ToString(product.Cells[2].Value).Trim();
                    int indexofbr = productnames.IndexOf("(");
                    productnames = productnames.Substring(0, indexofbr).Trim();
                    int ProductId = Convert.ToInt32(Convert.ToString(product.Cells[0].Value));
                    
                    DataBaseLayer.datebase.NewPurchase(int.Parse(supplierID.Trim()), purchaseID, ProductId, productnames, int.Parse(product.Cells[1].Value.ToString()), Convert.ToString(product.Cells[3].Value.ToString()), float.Parse(product.Cells[6].Value.ToString()), float.Parse(product.Cells[7].Value.ToString()), float.Parse(product.Cells[5].Value.ToString()), product.Cells[4].Value.ToString());
                    
                }
            }
        }
    }
}


