using EmployeeManagement.DataLayer.Context;
using EmployeeManagement.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.Repositorise
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly ProjectDbContext _projectDbContext;
        public EmployeeRepository(ProjectDbContext projectDbContext) 
        {
            _projectDbContext = projectDbContext;
        }

        public async Task<EmployeeDetailEntity> GetEmployeeInfo(int id)
        {
            return await _projectDbContext.EmployeeDetails.FindAsync(id);
        }

        public async Task<EmployeeDetailEntity> AddEmployee(EmployeeDetailEntity employeeDetailEntity)
        {
            await _projectDbContext.EmployeeDetails.AddAsync(employeeDetailEntity);
            await _projectDbContext.SaveChangesAsync();
            return employeeDetailEntity;
        }
    }
}
