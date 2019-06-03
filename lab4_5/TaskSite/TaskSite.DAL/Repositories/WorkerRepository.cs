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
    public class WorkerRepository : IRepository<Worker>
    {
        private TaskContext db;
        public WorkerRepository(TaskContext context)
        {
            this.db = context;
        }

        public void Create(Worker item)
        {
            db.Workers.Add(item);
        }

        public void Delete(int id)
        {
            Worker worker = db.Workers.Find(id);
            if (worker != null)
                db.Workers.Remove(worker);
        }

        public IEnumerable<Worker> Find(Func<Worker, bool> predicate)
        {
            return db.Workers.Where(predicate).ToList();
        }

        public Worker Get(int id)
        {
            return db.Workers.Find(id);
        }

        public IEnumerable<Worker> GetAll()
        {
            return db.Workers;
        }

        public void Update(Worker item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
