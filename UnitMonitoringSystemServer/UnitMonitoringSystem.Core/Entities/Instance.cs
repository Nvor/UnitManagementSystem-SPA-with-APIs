using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMonitoringSystem.Core.Entities
{
    public class Instance : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<Unit> Units { get; set; }
    }
}
