using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6B_Moon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text.Trim();
            DateTime departure = monthCalendar1.SelectionStart;
            AstronautTrip at = new AstronautTrip(name, departure);
            AstronautTrip at2 = new AstronautTrip(name, departure);
            if (at.Equals(at2))
                return;
        }
    }
}
