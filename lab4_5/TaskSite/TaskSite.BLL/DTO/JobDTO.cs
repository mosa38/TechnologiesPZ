using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSite.BLL.DTO
{
    public class JobDTO
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public int WorkerId { get; set; }
    }
}
