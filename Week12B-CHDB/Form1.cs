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
        private List<Medication> meds = new List<Medication>();

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
            meds.Clear();

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
                    meds.Add(med);
                }
                UpdateLB(meds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medications due to: {ex.Message}");
            }
            //rdr?.Close();
            if (rdr != null)
                rdr.Close();
        }

        private void UpdateLB(IEnumerable<Medication> meds)
        {
            medsLB.Items.Clear();
            foreach (Medication med in meds)
                medsLB.Items.Add(med);
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

        private void applyBtn_Click(object sender, EventArgs e)
        {
            // get copy of medications
            IEnumerable<Medication> requestedMeds = meds;

            // get filter criteria
            string description = descTB.Text.Trim();
            if (description.Length > 0)
                requestedMeds = requestedMeds.Where(m => m.Description.Contains(description));
            if (costNUD.Value > 0)
                requestedMeds = requestedMeds.Where(m => m.Cost > costNUD.Value);
            requestedMeds = requestedMeds.Where(m => m.Last > lastDTP.Value);

            // get sort criteria
            if (defaultRB.Checked)
                requestedMeds = requestedMeds.OrderByDescending(m => m.Description);
            else if (descRB.Checked)
                requestedMeds = requestedMeds.OrderBy(m => m.Description);
            else if (costRB.Checked)
                requestedMeds = requestedMeds.OrderByDescending(m => m.Cost);
            else if (lastRB.Checked)
                requestedMeds = requestedMeds.OrderByDescending(m => m.Last);

            // update listbox
            UpdateLB(requestedMeds);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            descTB.ResetText();
            costNUD.Value = 0;
            lastDTP.Value = DateTime.Now.AddYears(-50);
            defaultRB.Checked = true;
            UpdateLB(meds);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            // LINQ method syntax with chaining
            var methodMeds = meds
                             .Where(med => med.Last > DateTime.Now.AddYears(-10))
                             .OrderByDescending(med => med.Last)
                             .Take(10)
                             .Select(med => new { med.Description, med.Cost, med.Last });

            // LINQ Query syntax
            var queryMeds = (from med in meds
                            where med.Last > DateTime.Now.AddYears(-10)
                            orderby med.Last descending
                            select new {med.Description, med.Cost, med.Last}).Take(10);

            // show the results
            medsLB.Items.Clear();
            foreach (var med in queryMeds)
                medsLB.Items.Add($"{med.Description,-25}, {med.Cost,6:C}, {med.Last.Date.ToShortDateString()}");
        }
    }
}
