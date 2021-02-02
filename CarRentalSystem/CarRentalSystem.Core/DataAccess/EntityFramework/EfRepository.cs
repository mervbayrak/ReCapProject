using CarRentalSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystem.Core.DataAccess.EntityFramework
{
    public class EfRepository<TContext, TEntity> : IRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Add(entity);
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault();
            }
        }

        public List<TEntity> GetList()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

       
    }
}
