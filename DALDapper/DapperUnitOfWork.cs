using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALDapper
{
    public class DapperUnitOfWork: IUnitofWork
    {
        public IRepository<Employee> Employeers { set; get; } = new RepositoryDapper<Employee>();
        public IRepository<Equipment> Equipments { set; get; } = new RepositoryDapper<Equipment>();

        public DapperUnitOfWork(IRepository<Employee> emp, IRepository<Equipment> eq)
        {
            Employeers = emp;
            Equipments = eq;
        }
    }
}
