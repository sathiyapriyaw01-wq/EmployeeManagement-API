using AutoMapper;
using EmployeeManagement.BusinessLayer.DTOs;
using EmployeeManagement.BusinessLayer.Interfaces;
using EmployeeManagement.DataLayer.Entity;
using EmployeeManagement.DataLayer.Repositorise;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BusinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _iemployeeRepository;
        private readonly IMapper _imapper;
        public EmployeeService(IEmployeeRepository iemployeeRepository, IMapper imapper) 
        {
            _iemployeeRepository = iemployeeRepository;
            _imapper = imapper;
        }
        public async Task<EmployeeDTO> GetEmployeeById(int id)
        {
            var res = await _iemployeeRepository.GetEmployeeInfo(id);
            return _imapper.Map<EmployeeDTO>(res);
        }

        public async Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO)
        {
            var entity = _imapper.Map<EmployeeDetailEntity>(employeeDTO);
            await _iemployeeRepository.AddEmployee(entity);
            return employeeDTO;
        }


    }
}
