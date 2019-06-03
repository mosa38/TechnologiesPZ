using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSite.DAL.Entities;
using TaskSite.DAL.EF;

namespace TaskSite.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        TaskContext Context { get; set; }
        IRepository<Worker> Workers { get; }
        IRepository<Job> Jobs { get; }

        void Save();
    }
}
