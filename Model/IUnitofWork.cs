using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUnitofWork
    {
        IRepository<Employee> Employeers { get; }
        IRepository<Equipment> Equipments { get; }
    }
}
