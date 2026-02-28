using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312_POE_Part2
{
    public static class SharedData
    {
        public static List<IssueReport> ReportedIssues { get; } = new List<IssueReport>();


        // Allow other forms to access them
        public static List<IssueReport> GetReportedIssues()
        {
            return ReportedIssues;
        }

        // Allow adding new issues from ReportIssues1
        public static void AddIssue(IssueReport issue)
        {
            ReportedIssues.Add(issue);
        }

        public static class SharedServiceRequests
        {
            public static ServiceRequestBST RequestBST = new ServiceRequestBST();
            public static ServiceRequestHeap RequestHeap = new ServiceRequestHeap();
            public static ServiceRequestGraph RequestGraph = new ServiceRequestGraph();

            public static int GetNextId()
            {
                // Try a deterministic approach: max existing ID + 1
                var all = RequestBST.InOrder();
                if (all.Count == 0) return 1;
                int max = all[all.Count - 1].ID;
                return max + 1;
            }

            // Convenience to get all requests (from BST inorder)
            public static List<ServiceRequest> GetAllRequests()
            {
                // return BST InOrder for stable ordering by ID
                return RequestBST.InOrder();
            }
        }
    }
}
