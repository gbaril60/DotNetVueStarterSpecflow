using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SpecflowDotNetCoreVue.Data;

namespace SpecflowDotNetCoreVue.Spec.Classes
{
    public class FakeRepository<T> : IRepository<T> where T : class
    {
        public IList<T> DataSet { get; set; } = new List<T>();
        public T Get(Func<T, bool> predicate)
        {
            return GetAll().Where(predicate).FirstOrDefault();
        }
        public IQueryable<T> GetAll()
        {
            return DataSet.AsQueryable();
        }

        public IRepository<T> Include(Expression<Func<T, object>> path)
        {
            throw new NotImplementedException();
        }

        public T Save(T item)
        {
            throw new NotImplementedException();
        }
    }
}
