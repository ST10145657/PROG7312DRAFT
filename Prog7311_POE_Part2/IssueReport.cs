using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7311_POE_Part2
{
    class IssueReport
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }

        public override string ToString()
        {
            return $"{Category} issue at {Location}";
        }
    }
}
