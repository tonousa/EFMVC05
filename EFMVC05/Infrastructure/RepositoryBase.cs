using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EFMVC05.Models;
using System.Data;
using System.Linq.Expressions;


namespace EFMVC05.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private EFMVCContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get; private set;
        }

        protected EFMVCContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Func<T, Boolean> where)
        {
            return dbset.Where(where).ToList();
        }

        public T Get(Func<T, bool> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }
}