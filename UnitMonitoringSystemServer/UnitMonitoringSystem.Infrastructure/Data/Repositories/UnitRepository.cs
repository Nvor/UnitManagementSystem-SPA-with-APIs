using System;
using System.Collections.Generic;
using System.Text;
using UnitMonitoringSystem.Core.Entities;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Infrastructure.Data.Repositories
{
    public class UnitRepository : BaseRepository<Unit>, IUnitRepository
    {
        public UnitRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
