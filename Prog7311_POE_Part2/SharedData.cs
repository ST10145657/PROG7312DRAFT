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
            public static Dictionary<int, ServiceRequest> RequestDictionary
                = new Dictionary<int, ServiceRequest>();

            public static void AddRequest(ServiceRequest request)
            {
                RequestBST.Insert(request);
                RequestHeap.Insert(request);
                RequestGraph.AddRequest(request);
                RequestDictionary[request.ID] = request;
            }

            public static void InitializeSampleData()
            {
                if (RequestDictionary.Count > 0)
                    return;

                var req1 = new ServiceRequest(201, "Greenfield Park", "Public Safety",
                    "Park Cleanup", "Submitted", 2);

                var req2 = new ServiceRequest(202, "City Bus Depot", "Utilities",
                    "Public Transport", "Submitted", 1);

                var req3 = new ServiceRequest(203, "Main Street", "Water",
                    "Burst Pipe", "Submitted", 3);

                AddRequest(req1);
                AddRequest(req2);
                AddRequest(req3);

                RequestGraph.AddDependency(201, 202);
                RequestGraph.AddDependency(203, 201);
            }

            public static int GetNextId()
            {
               
                var all = RequestBST.InOrder();
                if (all.Count == 0) return 1;
                int max = all[all.Count - 1].ID;
                return max + 1;
            }


            
            public static List<ServiceRequest> GetAllRequests()
            {
                // return BST InOrder for stable ordering by ID
                return RequestBST.InOrder();
            }
        }
    }
}
