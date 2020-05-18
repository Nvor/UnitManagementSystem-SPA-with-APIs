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

        public static List<Instance> GetTestInstanceData()
        {
            return new List<Instance>()
            {
                new Instance() { Id = 0, Name = "My Aquarium", Description = "An item collection for recording aquatic species and vegetation" },
                new Instance() { Id = 1, Name = "To-Do List" , Description = "Things we should probably take care of at some point" },
                new Instance() { Id = 2, Name = "Gymnasium", Description = "Hey there Hercules! What do you bench? How many reps? Let the gym know!" }
            };
        }
    }
}
