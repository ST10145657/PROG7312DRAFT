using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7311_POE_Part2
{
    public class ServiceRequest
    {
        public int ID { get; set; } // Unique identifier
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Submitted, In Progress, Completed
        public int Priority { get; set; } // Optional, for heap sorting
        public DateTime CreatedAt { get; set; }

        public ServiceRequest(int id, string location, string category, string description, string status, int priority = 0)
        {
            ID = id;
            Location = location;
            Category = category;
            Description = description;
            Status = status;
            Priority = priority;
            CreatedAt = DateTime.Now;
        }
    }
}
