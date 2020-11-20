using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Infrastructure.Data.Repositories
{
    public class InstanceRepository : BaseRepository<Instance>, IInstanceRepository 
    {
        public InstanceRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Instance>> GetInstancesByIdWithUnits(int userId)
        {
            // Don't have users implemented atm, return all for now
            return dbContext.Set<Instance>()
                .Include(i => i.Units)
                .ToListAsync();
        }
    }
}
