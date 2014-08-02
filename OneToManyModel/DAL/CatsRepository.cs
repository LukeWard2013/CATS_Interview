using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using CATS_Interview.Model;

namespace CATS_Interview.DAL
{
    public class CatsRepository:ICatsRepository
    {
        private DatabaseContext _context;
        
        public CatsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> filter = null) where T : class
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
                query = query.Where(filter);

            return query;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State=EntityState.Modified;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }
    }
}