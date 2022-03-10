using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (Context context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context context = new Context ())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using (Context context=new Context ())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
