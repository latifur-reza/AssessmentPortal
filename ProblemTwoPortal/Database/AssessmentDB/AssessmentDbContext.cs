using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.AssessmentDB
{
    public class AssessmentDbContext : DbContext
    {
        private readonly string _connectionString;
        public AssessmentDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<DataField> DataField { get; set; }
        public virtual DbSet<Reading> Reading { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_connectionString);
            }
        }
    }
}
