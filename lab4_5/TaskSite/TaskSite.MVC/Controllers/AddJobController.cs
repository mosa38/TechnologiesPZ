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

namespace TaskSite.MVC.Controllers
{
    public class AddJobController : Controller
    {
        IManagment managment;
        public AddJobController(IManagment serv)
        {
            managment = serv;
        }
        [HttpGet]
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJob(JobViewModel jvm)
        {
            try
            {
                var jobs = new JobDTO { WorkerId = 1, Time = jvm.Time, Name = jvm.Name, Priority = jvm.Priority, Status = jvm.Status };
                managment.AddJob(jobs);
                return Content("<h2>Job was succesful added</h2>");
            }
            catch (HttpRequestValidationException ex)
            {

                ModelState.AddModelError(ex.Source, ex.Message);
                return Content("<h2>Job was not succesful added</h2>");
            }
        }
    }
}