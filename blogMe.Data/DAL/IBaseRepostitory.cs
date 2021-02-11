using System;
using System.Collections.Generic;

namespace blogMe.Data.DAL
{
    public interface IBaseRepostitory<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Add(T t);
        void Update(T t);
        void Remove(Guid id);
        void Save();
        void UpdateIsPublic(T t);
    }
}