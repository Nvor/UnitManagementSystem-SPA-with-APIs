using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Infrastructure.Data.Repositories
{
    public class UnitRepository : BaseRepository<Unit>, IUnitRepository
    {
        public UnitRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public virtual async Task<List<Unit>> GetUnitsByInstanceId(int instanceId)
        {
            return await dbContext.Set<Unit>()
                .Where(u => u.InstanceId == instanceId)
                .ToListAsync();
        }
    }
}
