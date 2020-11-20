using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMonitoringSystem.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
