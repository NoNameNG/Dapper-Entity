using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace EF
{
    public class EFRepository<T>: IRepository<T> where T: class, IDomainObject, new()
    {
        public Context _context = new Context();

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }


        public void Create(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).CurrentValues.SetValues(obj);
        }

        public void Delete(int id)
        {

            T t = _context.Set<T>().Find(id);
            if (t != null)
            {
                _context.Set<T>().Remove(t);
            }
            _context.SaveChanges();

          /*  if (this.GetType().GenericTypeArguments[0].Name == "Employee")
            {
                T emp = _context.Set<T>().Local.FirstOrDefault(x => x.id == id);
                if (emp == null)
                {
                    emp = new T() { id = id };
                    _context.Set<T>().Attach(emp);
                }
                _context.Set<T>().Remove(emp);
            }

            if (this.GetType().GenericTypeArguments[0].Name == "Equipment")
            {
                T eq = _context.Set<T>().Local.FirstOrDefault(x => x.id == id);

                if (eq == null)
                {
                    eq = new T() { id = id };
                    _context.Set<T>().Attach(eq);
                }

                _context.Set<T>().Remove(eq);
            }
            _context.SaveChanges(); */

        }

        public void Save()
        {
            _context.SaveChanges();
        } 
    }
}
