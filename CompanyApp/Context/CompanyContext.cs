using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using CompanyApp.Models;

namespace CompanyApp.Context
{
    class CompanyContext:DbContext
    {
        private const string connctionString = "server=DESKTOP-HQIELD6\\SQLEXPRESS;Database=CompanyDb;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connctionString);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTeam> ProjectTeams { get; set; }
       
        public DbSet<vEmployee> vEmployees { get; set; }

        public DbSet<vProject> vProjects { get; set; }

        public DbSet<vProjectTeam> vProjectTeams { get; set; }


    }
}
