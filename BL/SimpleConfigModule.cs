using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using EF;
using Model;
using DALDapper;

namespace BL
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IUnitofWork>().To<EFUnitOfWork>().InSingletonScope();
            //Bind<IRepository<Employee>>().To<EFRepository<Employee>>().InSingletonScope();
            //Bind<IRepository<Equipment>>().To<EFRepository<Equipment>>().InSingletonScope(); 

            Bind<IUnitofWork>().To<DapperUnitOfWork>().InSingletonScope();
            Bind<IRepository<Employee>>().To<RepositoryDapper<Employee>>().InSingletonScope();
            Bind<IRepository<Equipment>>().To<RepositoryDapper<Equipment>>().InSingletonScope(); 

        }
    }
}
