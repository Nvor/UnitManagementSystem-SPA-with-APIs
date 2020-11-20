using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitMonitoringSystem.Core.Entities;

namespace UnitMonitoringSystem.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Unit> Units { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instance>().HasData(
                new Instance() { ID = 1, Name = "My Aquarium", Description = "An item collection for recording aquatic species and vegetation" },
                new Instance() { ID = 2, Name = "To-Do List", Description = "Things we should probably take care of at some point" },
                new Instance() { ID = 3, Name = "Gymnasium", Description = "Hey there Hercules! What do you bench? How many reps? Let the gym know!" }
            );

            modelBuilder.Entity<Unit>().HasData(
                new Unit() { ID = 1, Name = "Generic Unit 1", Description = "Description 1", Created = DateTime.Now.AddDays(-10), InstanceId = 1 },
                new Unit() { ID = 2, Name = "Generic Unit 2", Description = "Description 2", Created = DateTime.Now.AddDays(-9), InstanceId = 1 },
                new Unit() { ID = 3, Name = "Generic Unit 3", Description = "Description 3", Created = DateTime.Now.AddDays(-8), InstanceId = 1 },
                new Unit() { ID = 4, Name = "Generic Unit 4", Description = "Description 4", Created = DateTime.Now.AddDays(-7), InstanceId = 1 },
                new Unit() { ID = 5, Name = "Generic Unit 5", Description = "Description 5", Created = DateTime.Now.AddDays(-6), InstanceId = 1 },
                new Unit() { ID = 6, Name = "Generic Unit 6", Description = "Description 6", Created = DateTime.Now.AddDays(-5), InstanceId = 1 },
                new Unit() { ID = 7, Name = "Generic Unit 7", Description = "Description 7", Created = DateTime.Now.AddDays(-4), InstanceId = 1 },
                new Unit() { ID = 8, Name = "Generic Unit 8", Description = "Description 8", Created = DateTime.Now.AddDays(-3), InstanceId = 1 },
                new Unit() { ID = 9, Name = "Generic Unit 9", Description = "Description 9", Created = DateTime.Now.AddDays(-2), InstanceId = 1 },
                new Unit() { ID = 10, Name = "Generic Unit 10", Description = "Description 10", Created = DateTime.Now.AddDays(-1), InstanceId = 1 },

                new Unit() { ID = 11, Name = "Generic Unit 1", Description = "Description 1", Created = DateTime.Now.AddDays(-10), InstanceId = 2 },
                new Unit() { ID = 12, Name = "Generic Unit 2", Description = "Description 2", Created = DateTime.Now.AddDays(-9), InstanceId = 2 },
                new Unit() { ID = 13, Name = "Generic Unit 3", Description = "Description 3", Created = DateTime.Now.AddDays(-8), InstanceId = 2 },

                new Unit() { ID = 14, Name = "Generic Unit 1", Description = "Description 1", Created = DateTime.Now.AddDays(-10), InstanceId = 3 },
                new Unit() { ID = 15, Name = "Generic Unit 2", Description = "Description 2", Created = DateTime.Now.AddDays(-9), InstanceId = 3 },
                new Unit() { ID = 16, Name = "Generic Unit 3", Description = "Description 3", Created = DateTime.Now.AddDays(-8), InstanceId = 3 }
            );
        }
    }
}