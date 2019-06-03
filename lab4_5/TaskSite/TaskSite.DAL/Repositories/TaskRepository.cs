using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskSite.DAL.EF;
using TaskSite.DAL.Entities;
using TaskSite.DAL.Interfaces;

namespace TaskSite.DAL.Repositories
{
    public class TaskRepository : IRepository<Job>
    {
        private TaskContext db;
        public TaskRepository(TaskContext context)
        {
            this.db = context;
        }

        public void Create(Job item)
        {
            db.Jobs.Add(item);
        }

        public void Delete(int id)
        {
            Job Jobs = db.Jobs.Find(id);
            if (Jobs != null)
                db.Jobs.Remove(Jobs);
        }

        public IEnumerable<Job> Find(Func<Job, bool> predicate)
        {
            return db.Jobs.Where(predicate).ToList();
        }

        public Job Get(int id)
        {
            return db.Jobs.Find(id);
        }

        public IEnumerable<Job> GetAll()
        {
            return db.Jobs;
        }

        public void Update(Job item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
