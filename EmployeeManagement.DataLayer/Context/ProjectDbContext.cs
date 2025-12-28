using EmployeeManagement.DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.Context
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options):base (options) { }
        public DbSet<EmployeeDetailEntity> EmployeeDetails { get; set; }
    }
}
