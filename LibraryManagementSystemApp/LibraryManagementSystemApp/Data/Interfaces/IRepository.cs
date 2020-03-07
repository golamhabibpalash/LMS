﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystemApp.Data.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T GetByID(int id);
        void Create(T entity);
        void update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);

    }
}
