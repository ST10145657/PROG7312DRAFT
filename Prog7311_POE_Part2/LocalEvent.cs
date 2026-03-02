using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312_POE_Part2
{
    class LocalEvent
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
       

        public override string ToString()
        {
            return $"{Title} - {Category} ({Date:dd MMM yyyy})";
        }
    }
}
