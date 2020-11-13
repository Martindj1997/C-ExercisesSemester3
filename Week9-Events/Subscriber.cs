using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    class Subscriber : IComparable<Subscriber>
    {
        public string Name { get; set; }
        public NewIssueEventArgs LastIssue { get; set; }

        public Subscriber(string name)
        {
            Name = name;
            LastIssue = new NewIssueEventArgs();
        }

        public void NewIssueCallBack(object sender, EventArgs e)
        {

        }

        public void NewIssueCustomCallBack(object sender, NewIssueEventArgs e)
        {
            LastIssue.Name = e.Name;
            LastIssue.Time = e.Time;
        }

        public override string ToString()
        {
            return $"{Name}, {LastIssue.Name}, {LastIssue.Time}";
        }

        public int CompareTo(Subscriber other)
        {
            // Check whether other null, return 1 (greater if so)
            if (other == null)
                return 1;

            // Compare the objects using the Name field
            return Name.CompareTo(other.Name);
        }
    }
}
