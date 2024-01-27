using Point_Of_Sale.StockForm;
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
    public partial class Frm_Inventory_System : Form
    {
        public Frm_Inventory_System()
        {
            InitializeComponent();
        }

        private void Frm_Inventory_System_Load(object sender, EventArgs e)
        {
            tslabledate1.Text = DateTime.Now.ToString("ddd mmmm yyy hh:mm:ss PM");
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Category fc = new Form_Category();
            fc.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducts fp = new formProducts();
            fp.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplier fs = new FrmSupplier();
            fs.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers fc = new FrmCustomers();
            fc.ShowDialog();
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPurchase np = new NewPurchase();
            np.ShowDialog();
        }

        private void purchasePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPurchasePayment npp = new NewPurchasePayment();
            npp.ShowDialog();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSales ns = new NewSales();
            ns.ShowDialog();
        }
    }
}
