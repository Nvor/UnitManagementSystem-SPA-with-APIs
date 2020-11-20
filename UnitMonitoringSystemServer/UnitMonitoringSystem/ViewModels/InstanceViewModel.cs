using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitMonitoringSystem.Api.ViewModels
{
    public class InstanceViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<UnitViewModel> Units { get; set; }
    }
}
