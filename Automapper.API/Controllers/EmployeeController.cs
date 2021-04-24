using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController()]
public class EmployeeController : ControllerBase
{
    private readonly IMapper _mapper;

    public EmployeeController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet]
    public IEnumerable<EmployeeDTO> GetEmployees()
    {
        /* 
        Assume it to be a  service call/database call
        it returns a list of employee, and now we will map it to EmployeeDTO
        */
        var employees = Employee.SetupEmployee();
        var employeeDTO = _mapper.Map<IEnumerable<EmployeeDTO>>(employees);
        return employeeDTO;

    }
}