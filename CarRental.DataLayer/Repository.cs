﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CarRental.EF
{
    public class Repository : IRepository
    {

        private CarRentalContext context;
        public CarRentalContext Context
        {
            get
            {
                return context;
            }
        }
        public Repository() : this(new CarRentalContext())
        {
        }
        public Repository(CarRentalContext ctx)
        {
            context = ctx;
        }

        public void Add<T>(T entity) where T : class
        {
            Context.Set<T>().Add(entity);
        }

        public void AddRange<T>(ICollection<T> entities) where T : class
        {
            Context.Set<T>().AddRange(entities);
        }

        public IQueryable<T> DataSet<T>() where T : class
        {
            return Context.Set<T>();
        }

        public void Update<T>(T entity) where T : class
        {
            //Context.Set<T>().Update(entity);
        }

        public ICollection<T> FindBy<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return Context.Set<T>().Where(predicate).ToList<T>();
        }

        public void Remove<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);
        }

        public void RemoveRange<T>(ICollection<T> entities) where T : class
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
