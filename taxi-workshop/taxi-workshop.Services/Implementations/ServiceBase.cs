﻿using taxi_workshop.DataAccess;
using taxi_workshop.DomainModels.Models;
using taxi_workshop.Services.Interfaces;

namespace taxi_workshop.Services.Implementations
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IDb<T> _db;

        public ServiceBase()
        {
            _db = new fileSystemDb<T>();
        }

        public void Add(T entity)
        {
            _db.Insert(entity);
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public T GetSingle(int id)
        {
            return _db.GetById(id);
        }

        public void Remove(int id)
        {
            _db.DeleteById(id);
        }
    }
}
