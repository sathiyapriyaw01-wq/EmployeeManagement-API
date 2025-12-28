using AutoMapper;
using EmployeeManagement.BusinessLayer.DTOs;
using System.Runtime;
using EmployeeManagement.DataLayer.Entity;

namespace EmployeeManagement.BusinessLayer
{
    public class MapperClass : Profile
    {
        public MapperClass() 
        {
            CreateMap<EmployeeDTO,EmployeeDetailEntity>();
            CreateMap<EmployeeDetailEntity,EmployeeDTO>();
        }
    }
}
