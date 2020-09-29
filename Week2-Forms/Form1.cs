using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Week2___ModelView;

namespace Week2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listAllBtn_Click(object sender, EventArgs e)
        {
            Car myCar = new Car("Make", "Model", 50, 500);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                fileName = openFileDialog1.FileName;
            //if (dr.)
            // Please complete this on your own time along with the rest of the exercise!
        }
    }
}
