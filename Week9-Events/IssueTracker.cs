using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    static class IssueTracker
    {
        public static void AddPublisher(Publisher pub)
        {
            pub.NewIssueCustomArgs += NewIssueCallbackCustom;
        }

        private static void NewIssueCallbackCustom(object sender, NewIssueEventArgs e)
        {
            string newIssue = $"Issue: {e.Name}, Date: {e.Time}";

            // notify marketing

            // notify affiliates

            // notify account payable

            // store to database
        }
    }
}
