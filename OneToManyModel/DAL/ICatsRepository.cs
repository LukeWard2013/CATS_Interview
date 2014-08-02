using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CATS_Interview.DAL
{
    public interface ICatsRepository
    {
        IQueryable<T> Query<T>(Expression<Func<T, bool>> filter = null) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}