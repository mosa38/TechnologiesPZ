using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using TaskSite.DAL.Interfaces;
using TaskSite.DAL.Repositories;

namespace TaskSite.BLL.Infrustructute
{
    public class TaskModule : NinjectModule
    {
        private string connectionString;
        public TaskModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
