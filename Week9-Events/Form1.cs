using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_Events
{
    public partial class Form1 : Form
    {
        private List<Subscriber> Subscribers { get; set; } = new List<Subscriber>();
        private List<Publisher> Publishers { get; set; } = new List<Publisher>();
        private enum SortAlgorithms { SORT_ICOMPARABLE, SORT_LINQ, SORT_LAMBDA };
        private SortAlgorithms sortAlgorithm = SortAlgorithms.SORT_ICOMPARABLE;

        public Form1()
        {
            InitializeComponent();
        }

        private void addPubBtn_Click(object sender, EventArgs e)
        {
            Publisher pub = new Publisher(pubTB.Text);
            Publishers.Add(pub);
            pubCLB.Items.Add(pub);
            IssueTracker.AddPublisher(pub);
        }

        private void addSubBtn_Click(object sender, EventArgs e)
        {
            Subscriber sub = new Subscriber(subTB.Text);
            Subscribers.Add(sub);
            RefreshSubscribers();
        }

        private void SortSubscribers()
        {
            if (sortAlgorithm == SortAlgorithms.SORT_ICOMPARABLE)
                Subscribers.Sort();
            else if (sortAlgorithm == SortAlgorithms.SORT_LINQ)
            {
                var result = from sub in Subscribers
                             orderby sub.Name
                             select sub;
                Subscribers = result.ToList();
            }
            else if (sortAlgorithm == SortAlgorithms.SORT_LAMBDA)
                Subscribers.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            if (pubCLB.SelectedIndex == -1)
                return;

            Publisher pub = pubCLB.SelectedItem as Publisher;
            pub.NewRelease();
            RefreshSubscribers();
        }

        private void RefreshSubscribers()
        {
            subLB.Items.Clear();
            SortSubscribers();
            foreach (Subscriber sub in Subscribers)
                subLB.Items.Add(sub);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (subLB.SelectedIndex == -1)
                return;

            Subscriber sub = subLB.SelectedItem as Subscriber;

            foreach (Publisher pub in pubCLB.Items)
            {
                pub.NewIssue -= sub.NewIssueCallBack;
                pub.NewIssueCustomArgs -= sub.NewIssueCustomCallBack;
            }

            foreach (Publisher pub in pubCLB.CheckedItems)
            {
                pub.NewIssue += sub.NewIssueCallBack;
                pub.NewIssueCustomArgs += sub.NewIssueCustomCallBack;
            }
        }

        private void sortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortCB.SelectedIndex == 0)
                sortAlgorithm = SortAlgorithms.SORT_ICOMPARABLE;
            else if (sortCB.SelectedIndex == 1)
                sortAlgorithm = SortAlgorithms.SORT_LINQ;
            else if (sortCB.SelectedIndex == 2)
                sortAlgorithm = SortAlgorithms.SORT_LAMBDA;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sortCB.SelectedIndex = 0;
        }
    }
}
