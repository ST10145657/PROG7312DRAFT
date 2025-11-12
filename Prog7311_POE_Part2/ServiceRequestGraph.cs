using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog7311_POE_Part2.SharedData;

namespace Prog7311_POE_Part2
{
    public class ServiceRequestGraph
    {

        private readonly Dictionary<int, HashSet<int>> adjacency = new Dictionary<int, HashSet<int>>();

        public void AddRequest(ServiceRequest r)
        {
            if (!adjacency.ContainsKey(r.ID))
                adjacency[r.ID] = new HashSet<int>();
        }

        public void AddDependency(int fromRequestId, int toRequestId)
        {
            AddRequest(new ServiceRequest(fromRequestId, string.Empty, string.Empty, "", "Submitted", 1));
            AddRequest(new ServiceRequest(toRequestId, string.Empty, string.Empty, "", "Submitted", 1));
            adjacency[fromRequestId].Add(toRequestId);
        }

        public List<int> GetDependencies(int requestId)
        {
            if (!adjacency.ContainsKey(requestId)) return new List<int>();
            return adjacency[requestId].ToList();
        }

        // For display: get adjacency snapshot
        public Dictionary<int, List<int>> GetAdjacencySnapshot()
        {
            return adjacency.ToDictionary(kv => kv.Key, kv => kv.Value.ToList());
        }

        public void InitializeSampleData()
        {
            // 🧹 Community Events -> ServiceRequests
            var req1 = new ServiceRequest(201, "Greenfield Park", "Community", "Park Cleanup: Join the community to clean up Greenfield Park. Gloves and bags provided.", "Submitted", 2)
            {
                CreatedAt = DateTime.Now.AddDays(2)
            };
            var req2 = new ServiceRequest(202, "Local Library", "Education", "Coding for Beginners Workshop: Free coding class hosted by the local library.", "Submitted", 1)
            {
                CreatedAt = DateTime.Now.AddDays(4)
            };
            var req3 = new ServiceRequest(203, "Community Center", "Health", "Blood Donation Drive: Donate blood and help save lives. Refreshments provided.", "Submitted", 3)
            {
                CreatedAt = DateTime.Now.AddDays(1)
            };

            // Insert into BST
            SharedServiceRequests.RequestBST.Insert(req1);
            SharedServiceRequests.RequestBST.Insert(req2);
            SharedServiceRequests.RequestBST.Insert(req3);

            // Add to Graph
            SharedServiceRequests.RequestGraph.AddRequest(req1);
            SharedServiceRequests.RequestGraph.AddRequest(req2);
            SharedServiceRequests.RequestGraph.AddRequest(req3);

            // Example dependencies
            SharedServiceRequests.RequestGraph.AddDependency(201, 202); // Park Cleanup depends on Coding Workshop
            SharedServiceRequests.RequestGraph.AddDependency(203, 201); // Blood Drive depends on Park Cleanup
        }


    }

}

