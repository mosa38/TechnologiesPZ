using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSite.DAL.Interfaces;
using TaskSite.BLL.DTO;
using TaskSite.DAL.Entities;

namespace TaskSite.BLL.Managment
{
    public interface IManagment
    {
        IUnitOfWork UnitOfWork { get; set; }
        void AddJob(JobDTO job);
        void AddWorker(WorkerDTO workerDTO);
        IEnumerable<WorkerDTO> GetWorkers();
        IEnumerable<JobDTO> GetJobs();
        void Dispose();
    }
}
