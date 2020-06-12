using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitMonitoringSystem.Models
{
    public class Unit
    {
        public int UnitId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public int InstanceId { get; set; }

        public static List<Unit> GetTestListOfTempUnits()
        {
            return new List<Unit>()
            {
                new Unit() { UnitId = 0, Name = "Generic Unit 1", Description = "Description 1 for Generic Unit 1 - Stuff abound Unit 1 Bla bla bla", DateCreated = DateTime.Now.AddDays(-10), InstanceId = 1},
                new Unit() { UnitId = 1, Name = "Generic Unit 2", Description = "Description 2 for Generic Unit 2 - Stuff abound Unit 2 Bla bla bla", DateCreated = DateTime.Now.AddDays(-9), InstanceId = 1},
                new Unit() { UnitId = 2, Name = "Generic Unit 3", Description = "Description 3 for Generic Unit 3 - Stuff abound Unit 3 Bla bla bla", DateCreated = DateTime.Now.AddDays(-8), InstanceId = 1},
                new Unit() { UnitId = 3, Name = "Generic Unit 4", Description = "Description 4 for Generic Unit 4 - Stuff abound Unit 4 Bla bla bla", DateCreated = DateTime.Now.AddDays(-7), InstanceId = 1},
                new Unit() { UnitId = 4, Name = "Generic Unit 5", Description = "Description 5 for Generic Unit 5 - Stuff abound Unit 5 Bla bla bla", DateCreated = DateTime.Now.AddDays(-6), InstanceId = 1},
                new Unit() { UnitId = 5, Name = "Generic Unit 6", Description = "Description 6 for Generic Unit 6 - Stuff abound Unit 6 Bla bla bla", DateCreated = DateTime.Now.AddDays(-5), InstanceId = 1},
                new Unit() { UnitId = 6, Name = "Generic Unit 7", Description = "Description 7 for Generic Unit 7 - Stuff abound Unit 7 Bla bla bla", DateCreated = DateTime.Now.AddDays(-4), InstanceId = 1},
                new Unit() { UnitId = 7, Name = "Generic Unit 8", Description = "Description 8 for Generic Unit 8 - Stuff abound Unit 8 Bla bla bla", DateCreated = DateTime.Now.AddDays(-3), InstanceId = 1},
                new Unit() { UnitId = 8, Name = "Generic Unit 9", Description = "Description 9 for Generic Unit 9 - Stuff abound Unit 9 Bla bla bla", DateCreated = DateTime.Now.AddDays(-2), InstanceId = 1},
                new Unit() { UnitId = 9, Name = "Generic Unit 10", Description = "Description 10 for Generic Unit 10 - Stuff abound Unit 10 Bla bla bla", DateCreated = DateTime.Now.AddDays(-1), InstanceId = 1},

                new Unit() { UnitId = 10, Name = "Generic Unit 1", Description = "Description 1 for Generic Unit 1 - Stuff abound Unit 1 Bla bla bla", DateCreated = DateTime.Now.AddDays(-10), InstanceId = 2},
                new Unit() { UnitId = 11, Name = "Generic Unit 2", Description = "Description 2 for Generic Unit 2 - Stuff abound Unit 2 Bla bla bla", DateCreated = DateTime.Now.AddDays(-9), InstanceId = 2},
                new Unit() { UnitId = 12, Name = "Generic Unit 3", Description = "Description 3 for Generic Unit 3 - Stuff abound Unit 3 Bla bla bla", DateCreated = DateTime.Now.AddDays(-8), InstanceId = 2},

                new Unit() { UnitId = 13, Name = "Generic Unit 1", Description = "Description 1 for Generic Unit 1 - Stuff abound Unit 1 Bla bla bla", DateCreated = DateTime.Now.AddDays(-10), InstanceId = 3},
                new Unit() { UnitId = 14, Name = "Generic Unit 2", Description = "Description 2 for Generic Unit 2 - Stuff abound Unit 2 Bla bla bla", DateCreated = DateTime.Now.AddDays(-9), InstanceId = 3},
                new Unit() { UnitId = 15, Name = "Generic Unit 3", Description = "Description 3 for Generic Unit 3 - Stuff abound Unit 3 Bla bla bla", DateCreated = DateTime.Now.AddDays(-8), InstanceId = 3},

                new Unit() { UnitId = 16, Name = "Generic Unit 1", Description = "Description 1 for Generic Unit 1 - Stuff abound Unit 1 Bla bla bla", DateCreated = DateTime.Now.AddDays(-10), InstanceId = 4},
                new Unit() { UnitId = 17, Name = "Generic Unit 2", Description = "Description 2 for Generic Unit 2 - Stuff abound Unit 2 Bla bla bla", DateCreated = DateTime.Now.AddDays(-9), InstanceId = 4},
                new Unit() { UnitId = 18, Name = "Generic Unit 3", Description = "Description 3 for Generic Unit 3 - Stuff abound Unit 3 Bla bla bla", DateCreated = DateTime.Now.AddDays(-8), InstanceId = 4},
            };
        }
    }
}
