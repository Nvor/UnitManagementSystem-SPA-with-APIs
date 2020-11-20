using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;

namespace UnitMonitoringSystem.Core.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllListAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
