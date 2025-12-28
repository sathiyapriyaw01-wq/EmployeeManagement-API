using EmployeeManagement.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.Repositorise
{
    public interface IEmployeeRepository
    {
        Task<EmployeeDetailEntity> GetEmployeeInfo(int id);
        Task<EmployeeDetailEntity> AddEmployee(EmployeeDetailEntity employeeDetailEntity);


    }
}
