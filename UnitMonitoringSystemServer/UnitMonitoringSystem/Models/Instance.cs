using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitMonitoringSystem.Models
{
    public class Instance
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Unit> Units { get; set; }

        public static List<Instance> GetTestInstanceData()
        {
            return new List<Instance>()
            {
                new Instance() { Id = 0, Name = "My Aquarium", Description = "An item collection for recording aquatic species and vegetation" },
                new Instance() { Id = 1, Name = "To-Do List" , Description = "Things we should probably take care of at some point" },
                new Instance() { Id = 2, Name = "Gymnasium", Description = "Hey there Hercules! What do you bench? How many reps? Let the gym know!" }
            };
        }

        public static List<Instance> GetAllTestInstanceData()
        {
            return new List<Instance>()
            {
                new Instance()
                {
                    Id = 1, Name = "Dashboard", Description = "Generic dashboard",
                    Units = Unit.GetTestListOfTempUnits().Where((u) => u.InstanceId == 1).ToList()
                },
                new Instance()
                {
                    Id = 1, Name = "My Aquarium", Description = "An item collection for recording aquatic species and vegetation",
                    Units = Unit.GetTestListOfTempUnits().Where((u) => u.InstanceId == 2).ToList()
                },
                new Instance()
                {
                    Id = 1, Name = "To-Do List", Description = "Things we should probably take care of at some point",
                    Units = Unit.GetTestListOfTempUnits().Where((u) => u.InstanceId == 3).ToList()
                },
                new Instance()
                {
                    Id = 1, Name = "Gymnasium", Description = "Hey there Hercules! What do you bench? How many reps? Let the gym know!",
                    Units = Unit.GetTestListOfTempUnits().Where((u) => u.InstanceId == 4).ToList()
                }
            };
        }
    }
}
