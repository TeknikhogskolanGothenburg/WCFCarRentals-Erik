using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CarRental.EF
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void AddRange<T>(ICollection<T> entities) where T : class;

        void Remove<T>(T entity) where T : class;
        void RemoveRange<T>(ICollection<T> entities) where T : class;

        IQueryable<T> DataSet<T>() where T : class;

        ICollection<T> FindBy<T>(Expression<Func<T, bool>> predicate) where T : class;

        void Update<T>(T entity) where T : class;

        void SaveChanges();
    }
}
