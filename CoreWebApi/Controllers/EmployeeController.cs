using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployees _employees;
        public EmployeeController(IEmployees employees) {
            _employees = employees;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employees.GetAllEmployee());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employees.GetEmployee(id));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] EmployeesModel emp)
        {
            return Ok(_employees.AddEmployee(emp));
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EmployeesModel emp)
        {
            if (id != emp.EmpId)
                return BadRequest();
            return Ok(_employees.UpdateEmployee(emp));
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_employees.DeleteEmployee(id));
        }
    }
}
