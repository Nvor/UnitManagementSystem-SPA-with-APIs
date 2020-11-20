using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;

namespace UnitMonitoringSystem.Core.Interfaces
{
    public interface IInstanceRepository : IAsyncRepository<Instance>
    {
        Task<List<Instance>> GetInstancesByIdWithUnits(int userId);
    }
}
