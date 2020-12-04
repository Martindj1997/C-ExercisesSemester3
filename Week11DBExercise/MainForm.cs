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

namespace Week12DBExercise
{
    public partial class MainForm : Form
    {
        public SqlConnection Connection { get; }
        String connectionString = @"Data Source=.;Initial Catalog=COMP10204ExerciseWeek12;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLabel.Text = "Connected to Database Successfully";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Database Connection failed - check Connection String : " +
                ex.Message;
            }
        }

        private void listCarsButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Cars", Connection);
                // Create new SqlDataReader object and read data from the command.
                SqlDataReader reader = command.ExecuteReader();
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    string output = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                        output += String.Format("{0,-10} | ", reader[i]);
                    resultsListBox.Items.Add(output);
                }
                statusLabel.Text = "Database Select Success";
                reader.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Database operation failed: " + ex.Message;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCarForm form = new AddCarForm(this); // Pass Reference to this class for other info
            form.ShowDialog(this);
            // Update the form with any changes to the DB
            listCarsButton_Click(this, null);
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] carFields = resultsListBox.SelectedItem.ToString().Split('|');
                bool result = int.TryParse(carFields[0].Trim(), out int carId);
                if (result)
                {
                    // build query with parameter for car id and update the parameter value
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Mileage WHERE car_id = @carId", Connection);
                    SqlParameter param = new SqlParameter("@carId", SqlDbType.Int);
                    param.Value = carId;
                    cmd.Parameters.Add(param);

                    int totalDistance = 0;
                    float gasUsed = 0;

                    // run select query to get all mileage entries for the car in question
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalDistance += (int)reader["endkm"] - (int)reader["startkm"];
                        gasUsed += (float)reader["gasused"];
                    }
                    reader.Close();

                    // calculate the mileage (L/100km)
                    double avgMileage = 0;
                    if (totalDistance != 0)
                    {
                        avgMileage = gasUsed / (totalDistance / 100);
                        mileageTB.Text = avgMileage.ToString("f2");
                    }
                    else
                        mileageTB.Text = "No trips found for this vehicle in the database";

                    vehicleTB.Text = $"{carFields[1].Trim()} {carFields[2].Trim()} {carFields[3].Trim()}";
                }

            }
            catch
            {

            }
        }
    }
}
