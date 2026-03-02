using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312_POE_Part2
{
    public class ServiceRequest
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Submitted, In Progress, Completed 
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public object Title { get; internal set; }

        public ServiceRequest(int id, string location, string category, string description, string status, int priority = 0, string Title = null)
        {
            ID = id;
            Location = location;
            Category = category;
            Description = description;
            Status = status;
            Priority = priority;
            this.Title = Title;
            CreatedAt = DateTime.Now;
        }
    }
}
