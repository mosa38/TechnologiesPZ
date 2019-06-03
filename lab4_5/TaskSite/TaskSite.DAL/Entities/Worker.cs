using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSite.DAL.Entities
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Busy { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
