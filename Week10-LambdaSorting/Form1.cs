using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_LambdaSorting
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        //public List<Student> Students { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Student>()
            {
                new Student("Joe", "Smith", 75, 87),
                new Student("Joanne","Smith", 75, 88),
                new Student("Harsh", "Patel", 55, 91),
                new Student("Mitel", "Patel", 82, 66),
                new Student("Ishwar", "Singh", 91, 93),
                new Student("Amy", "Nguyen", 91, 65)
            };

            //foreach (Student s in students)
            //studentLB.Items.Add(s);

            studentLB.Items.AddRange(students.ToArray());
        }

        private void grade1Btn_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.Grade1.CompareTo(s2.Grade1));
            UpdateList();
        }

        private void UpdateList()
        {
            studentLB.Items.Clear();
            studentLB.Items.AddRange(students.ToArray());
        }

        private void grade2Btn_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s2.Grade2.CompareTo(s1.Grade2));
            UpdateList();
        }

        private void averageBtn_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.Average.CompareTo(s2.Average));
            UpdateList();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.LastName.CompareTo(s2.LastName));
            UpdateList();
        }

        private void grade12Btn_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => {
                int result = s1.Grade1.CompareTo(s2.Grade1);
                if (result == 0)
                    result = s1.Grade2.CompareTo(s2.Grade2);
                return result;
            });
            UpdateList();
        }

    }
}
