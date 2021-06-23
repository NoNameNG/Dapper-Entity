using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DapperFrame
{
    public class DapperUnitOfWork : IUnitofWork
    {
        public IRepository<Employee> Employeers { set; get; } = new DapperRepository<Employee>();
        public IRepository<Equipment> Equipments { set; get; } = new DapperRepository<Equipment>();
    }
}
