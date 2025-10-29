using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsingCurdoperationEmployee.Data;
using UsingCurdoperationEmployee.Model;
using UsingCurdoperationEmployee.Model.Entity;

namespace UsingCurdoperationEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationContext dbcontex;

        public EmployeeController(ApplicationContext dbcontext) 
        {
            this.dbcontex = dbcontext;
        }
        [HttpGet]
        public IActionResult Get() 
        {

            return Ok(dbcontex.employess.ToList());
        }
        [HttpPost]
        public IActionResult AddEmployee(Addemploye addemp)
        {
            var employeeentity = new Employee()
            {
              EmpName = addemp.EmpName,
              EmpEmail = addemp.EmpEmail,
              Empphone = addemp.Empphone,
              EmpSal  = addemp.EmpSal

                
            };
            dbcontex.employess.Add(employeeentity);
            dbcontex.SaveChanges();
            return Ok(employeeentity);
        }
        [HttpGet]
        [Route("id")]
        public IActionResult GetAction(int id)
        {
            var employee = dbcontex.employess.Find(id);
            if(employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPut]
        [Route("id")]
        public IActionResult UpdateEmployee(int id, Addemploye emp)
        {
            var empss = dbcontex.employess.Find(id);    
            if(empss is null)
            {  return NotFound();
            }
            empss.EmpName = emp.EmpName;
            empss.EmpEmail = emp.EmpEmail;
            empss.Empphone = emp.Empphone;
            empss.EmpSal = emp.EmpSal;
            dbcontex.SaveChanges();
            return Ok(empss);
        }
        [HttpDelete]
        [Route("id")]
        public IActionResult DeleteEmp(int id)
        {
            var deleteemp = dbcontex.employess.Find(id);
            if(deleteemp is null)
            {
                return NotFound();

            }
            dbcontex.employess.Remove(deleteemp);
            dbcontex.SaveChanges();
            return Ok(deleteemp);
        }
    }
}
