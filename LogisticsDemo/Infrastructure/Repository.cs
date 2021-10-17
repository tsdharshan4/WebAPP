using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LogisticsDemo.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly Context ct;
        public readonly DbSet<T> dbSet;

        public Repository(Context context)
        {
            this.ct = context;
            this.dbSet = context.Set<T>();

        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable();
        }
    }
}
