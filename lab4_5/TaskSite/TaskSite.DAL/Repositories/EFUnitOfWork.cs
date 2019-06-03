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
    public class EFUnitOfWork : IUnitOfWork
    {
        public TaskContext Context { get; set; }
        private WorkerRepository workerRepository;
        private TaskRepository taskRepository;
        public EFUnitOfWork(string connectionString)
        {
            Context = new TaskContext(/*connectionString*/);
        }

        public IRepository<Worker> Workers
        {
            get
            {
                if (workerRepository == null)
                    workerRepository = new WorkerRepository(Context);
                return workerRepository;
            }
        }

        public IRepository<Job> Jobs
        {
            get
            {
                if (taskRepository == null)
                    taskRepository = new TaskRepository(Context);
                return taskRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
