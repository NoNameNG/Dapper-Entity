using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Equipment: IDomainObject
    {
        public int id { set; get; }
        public string Title { get; set; }

        public int EmployeeId { get; set; }
    }
}
