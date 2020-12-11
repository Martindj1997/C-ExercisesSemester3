using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13B_CHDBWithJoin
{
    public partial class Form1 : Form
    {
        private string conString = @"Data Source=.;Initial Catalog=DN20_CHDB3;Integrated Security=True";
        private SqlConnection dbCon;
        private List<Vendor> vendors = new List<Vendor>();
        private List<Item> items = new List<Item>();
        private List<VendorItem> vendorItems = new List<VendorItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dbCon = new SqlConnection(conString);
                dbCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening DB connection due to: {ex.Message}");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr = null;
            vendors.Clear();
            items.Clear();
            vendorItems.Clear();

            try
            {
                // prepare VendorItems query
                SqlCommand cmd = new SqlCommand("SELECT * FROM items JOIN vendors ON items.primary_vendor_id=vendors.vendor_id", dbCon);

                // execute query
                rdr = cmd.ExecuteReader();

                // process results
                while (rdr.Read())
                {
                    int id = (int)rdr[0];
                    string description = rdr[1].ToString();
                    decimal cost = (decimal)rdr[2];
                    string vendorName = rdr["vendor_name"].ToString();
                    decimal vendorTotalYTD = (decimal)rdr["purchases_ytd"];
                    VendorItem vendorItem = new VendorItem(id, description, cost, vendorName, vendorTotalYTD);
                    vendorItems.Add(vendorItem);
                }
                rdr?.Close();

                foreach (VendorItem vi in vendorItems)
                    vendorItemsLB.Items.Add(vi);

                //// prepare VENDORS query
                //cmd = new SqlCommand("SELECT * FROM vendors", dbCon);
                //rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{
                //    int id = (int)rdr[0];
                //    // complete to populate the vendors list
                //}

                //var vendItems = from item in items
                //                join vend in vendors on item.VendorId equals vend.Id
                //                select new VendorItem(item.Id, item.Description, item.Cost, vend.VendorName, vend.VendorTotalYTD);
                //foreach (VendorItem vi in vendItems)
                //    vendorItemsLLB.Items.Add(vi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading DB due to: {ex.Message}");
            }
        }
    }
}
