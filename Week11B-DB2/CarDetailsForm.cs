using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11B_DB2
{
    public partial class CarDetailsForm : Form
    {
        public CarDetailsForm()
        {
            InitializeComponent();
        }

        private void cARSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dN20_Cars5DataSet);

        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dN20_Cars5DataSet.CARS' table. You can move, or remove it, as needed.
            this.cARSTableAdapter.Fill(this.dN20_Cars5DataSet.CARS);

        }
    }
}
