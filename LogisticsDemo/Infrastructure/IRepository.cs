using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LogisticsDemo.Infrastructure
{
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();
            T Get(Expression<Func<T, bool>> where);
            
        }

}
