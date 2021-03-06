﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMonitoringSystem.Core.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int InstanceId { get; set; }
        public Instance Instance { get; set; }
    }
}
