using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;

namespace UnitMonitoringSystem.Core.Interfaces
{
    public interface IUnitRepository : IAsyncRepository<Unit>
    {
        Task<List<Unit>> GetUnitsByInstanceId(int instanceId);
    }
}
