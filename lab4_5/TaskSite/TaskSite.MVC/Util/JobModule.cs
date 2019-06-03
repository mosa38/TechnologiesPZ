using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using TaskSite.BLL.Infrustructute;
using TaskSite.BLL.Managment;

namespace TaskSite.MVC.Util
{
    public class JobModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IManagment>().To<Managment>();
        }
    }
}