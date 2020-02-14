using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REID.APPL.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public int Status { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
