using LabWebAPI0.Contracts.Data.Entities;
using LabWebAPI0.Database.Data.Configurations;
using Microsoft.EntityFrameworkCore;


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebAPI0.Database.Data
{
    public class LabWebApi0DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public LabWebApi0DbContext(DbContextOptions<LabWebApi0DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }


    }
}
