using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitMonitoringSystem.Api.ViewModels
{
    public class UnitViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int InstanceId { get; set; }
    }
}
