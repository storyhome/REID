using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REID.APPL.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Needed { get; set; }
        public Project Project { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}
