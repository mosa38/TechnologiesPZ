using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSite.MVC.Models
{
    public class WorkerViewModel
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Busy { get; set; }
    }
}