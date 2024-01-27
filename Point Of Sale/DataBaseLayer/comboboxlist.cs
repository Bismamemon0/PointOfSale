using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Point_Of_Sale.DataBaseLayer
{
    public class comboboxlist
    {
        public static void Categorylist (ComboBox cmbcategory)
        {
            DataTable dt = new DataTable();
            cmbcategory.Items.Add("select Categories");
            dt = DataBaseLayer.datebase.Retrivedata("select * from Categories");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Category in dt.Rows)
                {
                    cmbcategory.Items.Add(Category[1]);
                }
            }
            cmbcategory.SelectedIndex = 0;
        }
        public static void productlist(ComboBox cmbproduct,string Categoryid)
        {
            DataTable dt = new DataTable();
            cmbproduct.Items.Clear();
            cmbproduct.Items.Add("select Products");
            string query =string.Format("select * from Products Where  CategoryID= {0}", Categoryid);
            dt = DataBaseLayer.datebase.Retrivedata(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Category in dt.Rows)
                {
                    cmbproduct.Items.Add(Convert.ToString( Category[2]) +"("+ Convert.ToString(Category["Quality"]) + ")" );

                }
            }
            cmbproduct.SelectedIndex = 0;
        }
    }
}
