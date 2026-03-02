using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog7312_POE_Part2.SharedData;

namespace Prog7312_POE_Part2
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
        //public Dictionary<int, List<int>> GetAdjacencySnapshot()
        //{
        //    return adjacency.ToDictionary(kv => kv.Key, kv => kv.Value.ToList());
        //}

       


    }

}

