﻿using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.BaseRepository
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public TEntity Add(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity).Entity;
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Any(predicate);
        }

        public TEntity Delete(TKey key)
        {
            TEntity entity = GetById(key);
            _context.Set<TEntity>().Remove(entity);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(TKey key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> Getwhere(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        //public int Max(Expression<Func<TEntity, string>> predicate)
        //{
        //    return _context.Set<TEntity>().Max(predicate);
        //}
    }
}
