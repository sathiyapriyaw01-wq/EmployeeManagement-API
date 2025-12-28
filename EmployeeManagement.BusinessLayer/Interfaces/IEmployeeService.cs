using EmployeeManagement.BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BusinessLayer.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> GetEmployeeById(int id);
        Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO);
    }
}
    