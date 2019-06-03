using NUnit.Framework;
using TaskSite.BLL.Managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSite.BLL.Infrustructute;
using TaskSite.BLL.DTO;
using TaskSite.DAL.EF;
using TaskSite.DAL.Entities;
using TaskSite.DAL.Interfaces;
using TaskSite.DAL.Repositories;
using AutoMapper;


namespace TaskSite.BLLTests.Managment
{
    [TestFixture()]
    public class ManagmentTests
    {
        [Test()]
        public void ManagmentTest()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            //act
            unitOfWork = uow;
            //assert
            Assert.AreEqual(unitOfWork, uow);
        }
        [Test()]
        public void AddJob_JobIsAddSuccesful()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            unitOfWork = uow;
            JobDTO jobDTO = new JobDTO { Name = "Good test task",  Time = 3, Priority = 1, Status = "Not performed",WorkerId = 1 };
            IManagment managment = new TaskSite.BLL.Managment.Managment(unitOfWork);
            //act
            managment.AddJob(jobDTO);
            //assert
            Assert.IsNotEmpty(managment.GetJobs().ToList().Where(x => x.Name == "Good test task"));
        }
        [Test()]
        public void AddWorker_WorkerIsAddSuccesful()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            unitOfWork = uow;
            WorkerDTO workerDTO = new WorkerDTO { Name = "Oleg", Busy = "Not worked" };
            IManagment managment = new TaskSite.BLL.Managment.Managment(unitOfWork);
            //act
            managment.AddWorker(workerDTO);
            //assert
            Assert.IsNotEmpty(managment.GetWorkers().ToList().Where(x => x.Name == "Oleg"));
        }
        [Test()]
        public void Dispose_UnitOfWorkIsDispose()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            unitOfWork = uow;
            IManagment managment = new TaskSite.BLL.Managment.Managment(unitOfWork);
            //act
            managment.Dispose();
            //assert
            Assert.Pass();
        }
        [Test()]
        public void GetJob_JobWasFound()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            unitOfWork = uow;
            IManagment managment = new TaskSite.BLL.Managment.Managment(unitOfWork);
            //act
            int jobCount = managment.GetJobs().ToList().Count;
            //assert
            Assert.Greater(jobCount, 3);
        }
        [Test()]
        public void GetWorkers_WorkersWasFound()
        {
            //arrange
            IUnitOfWork unitOfWork;
            IUnitOfWork uow = new EFUnitOfWork("defaultconnection");
            unitOfWork = uow;
            IManagment managment = new TaskSite.BLL.Managment.Managment(unitOfWork);
            //act
            int workerCount = managment.GetWorkers().ToList().Count;
            //assert
            Assert.Greater(workerCount, 3);
        }
    }
}
