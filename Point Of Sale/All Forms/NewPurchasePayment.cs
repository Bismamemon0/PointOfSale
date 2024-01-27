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
    public partial class NewPurchasePayment : Form
    {
        public NewPurchasePayment()
        {
            InitializeComponent();
        }
        private string supplierID = string.Empty;

        private void ClearSearchCheckBox()
        {
            lblName.Text = string.Empty;
            lbl_CDontactno.Text = string.Empty;
            lbl_Description.Text = string.Empty;
            supplierID = string.Empty;
        }
        private void Setcolumnwidth()
        {
            dgvPurchase.Columns[0].Width = 80;
            dgvPurchase.Columns[1].Width = 180;
            dgvPurchase.Columns[2].Width = 180;
            dgvPurchase.Columns[3].Width = 150;

            dgvPurchaseDetail.Columns[0].Width = 80;
            dgvPurchaseDetail.Columns[1].Width = 180;
            dgvPurchaseDetail.Columns[2].Width = 120;
            dgvPurchaseDetail.Columns[3].Width = 158;
            dgvPurchaseDetail.Columns[4].Width = 130;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ep_Purchase.Clear();
            //ClearSearchCheckBox();
            //if (txt_searchSupplier.Text.Trim().Length == 0)
            //{
            //    ep_Purchase.SetError(txt_searchSupplier, "Please Enter Supplier Name./ContactNO With Country Code e.g(+92)");
            //    txt_searchSupplier.Focus();
            //    return;
            //}
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
                SlectedSupplierAllPurchase();
            }
            else
            {
                ClearSearchCheckBox();
                MessageBox.Show("Record Not Found");
            }
        }
        private void SlectedSupplierAllPurchase()
        {
            DataTable dt = new DataTable();
            dgvPurchase.Rows.Clear();
            string query =string.Format(("select * from purchase where companyid = {0}") , supplierID);
            dt = DataBaseLayer.datebase.Retrivedata(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow purchase in dt.Rows)
                {
                    dgvPurchase.Rows.Add(Convert.ToString(purchase["purchaseid"]),Convert.ToDateTime(purchase["purchasedate"]).ToString("dd MMMM,yyyy"), Convert.ToString(purchase["TotalAmount"]),Convert.ToString(purchase["Description"]));
                }
            }
        }

        private void NewPurchasePayment_Load(object sender, EventArgs e)
        {
            Setcolumnwidth();
        }
    }
}
