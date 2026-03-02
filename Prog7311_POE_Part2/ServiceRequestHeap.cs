using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog7312_POE_Part2.SharedData;

namespace Prog7312_POE_Part2
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

     

    }
}
