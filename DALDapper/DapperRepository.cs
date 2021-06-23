using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Configuration;

namespace DALDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbEmps;Integrated Security=true;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        public IDbConnection db = new SqlConnection(connectionString);

        public void Create(T t)
        {
           
                if (t.GetType().Name == "Employee")
                {
                    var sqlQuery = "INSERT INTO Employees (Name, Age, Salary, Position) VALUES(@Name, @Age, @Salary, @Position); SELECT CAST(SCOPE_IDENTITY() as int)";
                    int empId = db.Query<int>(sqlQuery, t).FirstOrDefault();
                    t.id = empId;
                }
                else if (t.GetType().Name == "Equipment")
                {
                    var sqlQuery = "INSERT INTO Equipments (Title, EmployeeId) VALUES(@Title, @EmployeeId); SELECT CAST(SCOPE_IDENTITY() as int)";
                    int Equipment_ID = db.Query<int>(sqlQuery, t).FirstOrDefault();
                    t.id = Equipment_ID;
                }
                
            /*var sqlQuery = "INSERT INTO Employees (Name, Age,Salary,Position)" +
                    " VALUES(@Name, @Age,@Salary,@Position);";
            db.Execute(sqlQuery, t); */

        }


        public IEnumerable<T> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                if (this.GetType().GenericTypeArguments[0].Name == "Employee")

                {
                    return db.Query<T>("SELECT * FROM Employees").ToList();
                }
                if (this.GetType().GenericTypeArguments[0].Name == "Equipment")

                {
                    return db.Query<T>("SELECT * FROM Equipments").ToList();
                }
                return null;
            }
            

        }

        public void Update(T t)
        {
            var sqlQuery = "UPDATE Employee " +
                "SET Name = @Name, Age = @Age, Salary =@Salary," +
                "Position = @Position " +
                "WHERE Id = @Id";
           // db.Execute(sqlQuery, t);

        }

        public void Delete(int id)
        {

            if (this.GetType().GenericTypeArguments[0].Name == "Employee")
            {
                var sqlQuery = "DELETE FROM Employees WHERE ID = @id";
                db.Execute(sqlQuery, new { id });
            }
            else if (this.GetType().GenericTypeArguments[0].Name == "Equipment")
            {
                var sqlQuery = "DELETE FROM Equipments WHERE ID = @id";
                db.Execute(sqlQuery, new { id });
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
