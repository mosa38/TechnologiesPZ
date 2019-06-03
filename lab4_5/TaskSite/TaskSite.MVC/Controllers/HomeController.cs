using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskSite.BLL.DTO;
using TaskSite.BLL.Managment;
using TaskSite.BLL.Infrustructute;
using AutoMapper;
using TaskSite.MVC.Models;
using System.Web.Razor;

namespace TaskSite.MVC.Controllers
{
    public class HomeController : Controller
    {
        IManagment managment;
        public HomeController(IManagment serv)
        {
            managment = serv;
        }

        public ActionResult Index(int? workers_list)
        {
            IEnumerable<WorkerDTO> workerDTOs = managment.GetWorkers();
            ViewBag.workers_list = new SelectList(workerDTOs, "WorkerId", "Name");
            IEnumerable<JobDTO> jobDtos = managment.GetJobs();
            if (workers_list != null && workers_list != 0)
            {
                jobDtos = jobDtos.Where(nx => nx.WorkerId == workers_list);
            }
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<JobDTO, JobViewModel>()).CreateMapper();
            var job = mapper.Map<IEnumerable<JobDTO>, List<JobViewModel>>(jobDtos);
            return View(job);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult AddJob(/*JobViewModel nvm*/)
        {
            IEnumerable<WorkerDTO> workerDTOs = managment.GetWorkers();
            ViewBag.workers_list = new SelectList(workerDTOs, "WorkerId", "Name");
            return View("AddJob");
        }
        [HttpPost]
        public ActionResult AddJob(JobViewModel jvm, int workers_list)
        {
            IEnumerable<WorkerDTO> workerDTOs = managment.GetWorkers();
            ViewBag.workers_list = new SelectList(workerDTOs, "WorkerId", "Name");
            if (ModelState.IsValid)
            {
                try
                {
                    var job = new JobDTO { WorkerId = workers_list, Time = jvm.Time, Name = jvm.Name, Priority = jvm.Priority, Status = jvm.Status };
                    managment.AddJob(job);
                    ViewBag.Message = "The job was added succesfully";
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(ex.Source, ex.Message);
                    ViewBag.Message = "The job was not added succesfully";
                }
            }
            return View(jvm);
        }
        [HttpGet]
        public ActionResult AddWorker()
        {
            return View("AddWorker");
        }
        [HttpPost]
        public ActionResult AddWorker(WorkerViewModel wvm)
        {
            try
            {
                var worker = new WorkerDTO { Name = wvm.Name, Busy = wvm.Busy };
                managment.AddWorker(worker);
                ViewBag.Message = "The worker was added succesfully";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Source, ex.Message);
                ViewBag.Message = "The worker was not added succesfully";
            }
            return View(wvm);
        }

    }
}