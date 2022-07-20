﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.BaseRepository
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> Getwhere(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        TEntity GetById(TKey key);
        bool Any(Expression<Func<TEntity, bool>> predicate);
        TEntity Delete(TKey key);
        //int Max(Expression<Func<TEntity, int>> predicate);
    }
}
