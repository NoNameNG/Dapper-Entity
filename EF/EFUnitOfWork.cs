using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace EF
{
    public class EFUnitOfWork: IUnitofWork
    {
        public IRepository<Employee> Employeers { get; set; } = new EFRepository<Employee>();
        public IRepository<Equipment> Equipments { get; set; } = new EFRepository<Equipment>();

        public EFUnitOfWork(IRepository<Employee> emp, IRepository<Equipment> eq)
        {
            Employeers = emp;
            Equipments = eq;
        }
    }
}
