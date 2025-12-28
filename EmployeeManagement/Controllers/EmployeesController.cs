using EmployeeManagement.BusinessLayer.DTOs;
using EmployeeManagement.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeesController: ControllerBase
    {
        private readonly IEmployeeService _iemployeeService;
        public EmployeesController(IEmployeeService employeeService)
        { 
            _iemployeeService = employeeService;
        }

        [HttpGet]
        [Route("GetEmployeeInfo")]
        public async Task <ActionResult<EmployeeDTO>> GetEmployeeInfo(int id)
        {
            if (id == null)
                return BadRequest();
            
            var res= await _iemployeeService.GetEmployeeById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("AddEmployeeInfo")]
        public async Task <ActionResult<EmployeeDTO>> AddEmployee([FromBody]EmployeeDTO employeeDTO) 
        {
            if (!ModelState.IsValid)
            return BadRequest(ModelState);

            var employeeInfo = await _iemployeeService.AddEmployee(employeeDTO);
            return CreatedAtAction(nameof(AddEmployee),employeeInfo);
        }
    }
}
