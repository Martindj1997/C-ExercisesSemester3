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
    public partial class MileageForm : Form
    {
        public MileageForm()
        {
            InitializeComponent();
        }

        private void mILEAGEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mILEAGEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dN20_Cars5DataSet);

        }

        private void MileageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dN20_Cars5DataSet.MILEAGE' table. You can move, or remove it, as needed.
            this.mILEAGETableAdapter.Fill(this.dN20_Cars5DataSet.MILEAGE);

        }
    }
}
