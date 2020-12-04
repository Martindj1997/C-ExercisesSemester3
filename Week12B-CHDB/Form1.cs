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

namespace Week12B_CHDB
{
    public partial class Form1 : Form
    {
        private string conString = @"Data Source=.;Initial Catalog=DN20_CHDB3;Integrated Security=True";
        private SqlConnection dbCon;
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
            medsLB.Items.Clear();

            try
            {
                // prepare query with parameters
                SqlCommand cmd = new SqlCommand("SELECT * FROM medications", dbCon);

                // execute query
                rdr = cmd.ExecuteReader();

                // process results
                while (rdr.Read())
                {
                    int id = (int)rdr[0];
                    string description = rdr[1].ToString();
                    decimal cost = (decimal)rdr[2];
                    string size = rdr[3].ToString();
                    string strength = rdr[4].ToString();
                    string sig = rdr[5].ToString();
                    int units = (int)rdr[6];
                    DateTime lastDate = (DateTime)rdr[7];

                    Medication med = new Medication(id, description, cost, size, strength, sig, units, lastDate);
                    medsLB.Items.Add(med);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medications due to: {ex.Message}");
            }
            //rdr?.Close();
            if (rdr != null)
                rdr.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (medsLB.SelectedIndex == -1)
                return;

            Medication med = medsLB.SelectedItem as Medication;

            // update record
            try
            {
                // prepare query with parameters
                SqlCommand cmd = new SqlCommand("UPDATE medications SET last_prescribed_date = @last WHERE medication_id = @id", dbCon);
                SqlParameter p1 = new SqlParameter("@last", SqlDbType.Date);
                p1.Value = DateTime.Now;
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@id", SqlDbType.Int);
                p2.Value = med.Id;
                cmd.Parameters.Add(p2);

                // execute query
                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    MessageBox.Show("Update failed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating medication due to: {ex.Message}");
            }
        }
    }
}
