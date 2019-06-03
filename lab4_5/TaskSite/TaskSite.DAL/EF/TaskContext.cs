using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskSite.DAL.Entities;

namespace TaskSite.DAL.EF
{
    public class TaskContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        //static TaskContext()
        //{
        //    Database.SetInitializer<TaskContext>(new TaskDBInitializer());
        //}
        public TaskContext(/*string connectionString*/)
            : base(/*connectionString*/"MyDb")
        {
        }
    }
    //public class TaskDBInitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    //{

    //}
}
