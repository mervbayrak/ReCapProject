using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetList();
    }
}
