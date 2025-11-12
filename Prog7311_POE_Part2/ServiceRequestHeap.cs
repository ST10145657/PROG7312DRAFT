using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog7311_POE_Part2.SharedData;

namespace Prog7311_POE_Part2
{
    public class ServiceRequestHeap
    {
          private readonly List<ServiceRequest> heap = new List<ServiceRequest>();

        // Insert and keep list sorted descending by Priority, then by CreatedAt (recent first)
        public void Insert(ServiceRequest r)
        {
            heap.Add(r);
            heap.Sort((a, b) =>
            {
                int cmp = b.Priority.CompareTo(a.Priority);
                if (cmp == 0) cmp = b.CreatedAt.CompareTo(a.CreatedAt);
                return cmp;
            });
        }

        public ServiceRequest ExtractMax()
        {
            if (heap.Count == 0) return null;
            var top = heap[0];
            heap.RemoveAt(0);
            return top;
        }

        public List<ServiceRequest> GetAllRequests() => heap.ToList();

        // If a request updates (status/priority), rebuild sorting
        public void Rebuild()
        {
            heap.Sort((a, b) =>
            {
                int cmp = b.Priority.CompareTo(a.Priority);
                if (cmp == 0) cmp = b.CreatedAt.CompareTo(a.CreatedAt);
                return cmp;
            });
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
