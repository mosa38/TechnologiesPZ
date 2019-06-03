using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSite.BLL.Managment;
using TaskSite.BLL.Infrustructute;
using TaskSite.BLL.DTO;
using TaskSite.DAL.EF;
using TaskSite.DAL.Entities;
using TaskSite.DAL.Interfaces;
using TaskSite.DAL.Repositories;
using AutoMapper;

namespace TaskSite.BLL.Managment
{
    public class Managment : IManagment
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public Managment(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }
        public void AddJob(JobDTO jobDTO)
        {
            Job jobs = new Job
            {
                Name = jobDTO.Name,
                Time = jobDTO.Time,
                Priority = jobDTO.Priority,
                Status = jobDTO.Status,
                WorkerId = jobDTO.WorkerId
            };
            UnitOfWork.Jobs.Create(jobs);
            UnitOfWork.Save();
        }
        public void Dispose()
        {
            UnitOfWork.Dispose();
        }

        public IEnumerable<WorkerDTO> GetWorkers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkerDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Worker>, IEnumerable<WorkerDTO>>(UnitOfWork.Workers.GetAll());
        }

        public IEnumerable<JobDTO> GetJobs()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Job, JobDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Job>, IEnumerable<JobDTO>>(UnitOfWork.Jobs.GetAll());
        }

        public void AddWorker(WorkerDTO workerDTO)
        {
            Worker worker = new Worker
            {
                Name = workerDTO.Name,
                Busy = workerDTO.Busy
            };
            UnitOfWork.Workers.Create(worker);
            UnitOfWork.Save();
        }
    }
}
