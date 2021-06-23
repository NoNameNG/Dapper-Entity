using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Model;

namespace ViewCon
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogical businessLogical = new BusinessLogical();

            //businessLogical.AddEmployee("Алексей", 33, 45000, "Программист");
            //businessLogical.AddEmployee("Альберт", 54, 90000, "Архитектор");

            int user = 0;

            while (user != 7)
            {
                Console.WriteLine("Выберите действие: 1 - Добавить сотрудника, 2 - Получить список сотрудников, 3 - Уволить сотрудника, 4 - Повысить зарплату, 5 - Изменить должность, 6 - Средний возраст сотрудников, 7 - Закончить работу");
                user = Int32.Parse(Console.ReadLine());

                if (user == 1)
                {
                    Console.WriteLine("Введите имя, возраст, зарплату и должность сотрудника");

                    businessLogical.AddEmployee(Console.ReadLine(), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Console.ReadLine());
                    Console.WriteLine();
                }

                if (user == 2)
                {
                    businessLogical.InfoEmp();
                }

                if (user == 3)
                {
                    Console.WriteLine("Кого хотите уволить?");
                    string DismissEmp = Console.ReadLine();
                    foreach (var emp in businessLogical.Employees)
                    {
                        if (DismissEmp == emp.Name)
                        {
                            businessLogical.DeleteEmployee(emp);
                            break;
                        }
                    }
                }

                if (user == 4)
                {
                    Console.WriteLine("Введите имя сотрудника, а затем сумму");
                    string RaiseEmp = Console.ReadLine();
                    foreach (var emp in businessLogical.Employees)
                    {
                        if (RaiseEmp == emp.Name)
                        {
                            businessLogical.RaiseSalary(emp, Int32.Parse(Console.ReadLine()));
                            break;
                        }
                    }
                }

                if (user == 5)
                {
                    Console.WriteLine("Введите имя сотрудника, а затем новую должность");
                    string changePosition = Console.ReadLine();
                    foreach (var emp in businessLogical.Employees)
                    {
                        if (changePosition == emp.Name)
                        {
                            businessLogical.ChangePosition(emp, Console.ReadLine());
                            break;
                        }
                    }
                }

                if (user == 6)
                {
                    Console.WriteLine("Средний возраст сотрудников: " + businessLogical.AverageAge());
                }
               
            }
           
            Console.ReadKey();
        }
    }
}
