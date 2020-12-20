﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenseHome.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<T> GetAsync(string id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetAsQueryable();
    }
}
