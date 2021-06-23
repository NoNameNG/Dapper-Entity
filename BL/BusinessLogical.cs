using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF;
using System.Data.SqlClient;
using DALDapper;

namespace BL
{
    public class BusinessLogical
    {
        // public IUnitofWork unitofWork { get; set; } = new EFUnitOfWork();

        //public IUnitofWork dapper = new DapperUnitOfWork();
        //public List<Employee> Employees = new List<Employee>();

        public IUnitofWork unitofWork { get; set; }

        public BusinessLogical(IUnitofWork UnitofWork)
        {
            unitofWork = UnitofWork;
        }


        public void DapperRemoveEmp(int id)
        {
            unitofWork.Employeers.Delete(id);
        }

        public void DapperRemoveEq(int id)
        {
            unitofWork.Equipments.Delete(id);
        }

        public IEnumerable<Employee> GetDapperEmp()
        {
            return unitofWork.Employeers.GetAll();
        }

        public IEnumerable<Equipment> GetDapperEq()
        {
            return unitofWork.Equipments.GetAll();
        }

        public void AddEmployeerDAP(string name, int age, int salary, string position)
        {
            Employee emp = new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Position = position
            };

            unitofWork.Employeers.Create(emp);


        }

        public void AddEquipmentDAP(string title, int employeeid)
        {
            Equipment eq = new Equipment()
            {
                Title = title,
                EmployeeId = employeeid
            };

            unitofWork.Equipments.Create(eq);
        }

        public void AddEmployeer(string name, int age, int salary, string position)
        {
            Employee emp = new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Position = position
            };

            unitofWork.Employeers.Create(emp);


        }

        public void AddEquipment(string title, int employeeid)
        {
            Equipment eq = new Equipment()
            {
                Title = title,
                EmployeeId = employeeid
            };

            unitofWork.Equipments.Create(eq);
        }

        public IEnumerable<Employee> GetEmployeer()
        {

            //return context.Employees.ToList();
            return unitofWork.Employeers.GetAll();

        }

        public IEnumerable<Equipment> GetEquipment()
        {
            return unitofWork.Equipments.GetAll();
        }

        public void RemoveEmp(int id)
        {
            unitofWork.Employeers.Delete(id);
           // unitofWork.Employeers.Save();
        }

        public void RemoveEq(int id)
        {
            unitofWork.Equipments.Delete(id);
        }

   /*     public void AddEmployee(string name, int age, int salary, string position)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Position = position
            };

            Employees.Add(employee);
        } */


    /*    public void InfoEmp()
        {
            Console.WriteLine("Список сотрудников:");
            foreach (var emp in Employees)
            {
                Console.WriteLine("Имя: " + emp.Name + " " + "Возраст: " + emp.Age + " " + "Зарплата: " + emp.Salary + " " + "Должность: " + emp.Position);
                Console.WriteLine();
            }
        }

        public void DeleteEmployee(Employee employees)
        {
            Employees.Remove(employees);
        } */

        public void RaiseSalary(Employee employee, int sum)
        {
            employee.Salary += sum;
        }

        public void ChangePosition(Employee employee, string NewPosition)
        {
            employee.Position = NewPosition;
        }

  /*      public void DeleteEmpForm(int id)
        {
            Employees.RemoveAt(id);
        } */

  /*      public int AverageAge()
        {
            int sum = 0;
            foreach (var emp in Employees)
            {
                sum += emp.Age;
                
            }
            return sum / Employees.Count;
        } */
    }
}
