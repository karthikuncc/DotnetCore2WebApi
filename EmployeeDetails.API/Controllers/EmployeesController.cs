
using System;
using EmployeeDetails.API.Data;
using System.Collections.Generic;
using EmployeeDetails.API.Models;
using EmployeeDetails.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.API.Controllers

{
      /// <summary>
    /// Employees controller provides interface to CRUD operations for Employees table. 
    /// </summary>
    [Route("/api/v1/[controller]")]
    public class EmployeesController:Controller
    {
          private EmployeeRepository _employeeRepository;

       /// <summary>
       /// EmployeesController Contstructor. DataContext is injected via Dependency Injection
       /// </summary>
 
        public EmployeesController(DataContext dbContext)
        {
            _employeeRepository = new EmployeeRepository(dbContext);
        }

        /// <summary>
        /// List all Employees in Employee collection.
        /// </summary>
        // Returns List of Employees objects
         [HttpGet]
      //  public IActionResult Get()
         public  IEnumerable<Employees> Get()
         {
            // Return list from Employee Repository
          //  try{
               // var list = _employeeRepository.List();
               // return Ok(list);
               Console.WriteLine("Hello World!");
               return _employeeRepository.List();
          //  }
            // Catch Errors and log them
          //  catch(Exception e){
                // Return error message that the action performed on this resource failed
              //  return BadRequest(new {message="There was an error  this resource " +e});
           // }
        }

          /// <summary>
        /// Get client with ID passed in query string
        /// </summary>
    
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try{
                // Create Employee and set it equal to Employee with ID passed in query string
                Employees employee = _employeeRepository.GetByID(id);
                // Ensure that ID specified exists
                if (employee != null)
                {
                    // Return the client response
                    return Ok(employee);
                }
                // Unable to find client ID specified
                return  NotFound();
            }
            // Catch Errors and log them
            catch(Exception e){
                // Return error message that the action performed on this resource failed
                return BadRequest(new {message=$"There was an error Getting this resource:{id}"});
            }
        }

        
    }
}



