using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //attribute routing
    public class EmployeeController : ControllerBase
    {
        private readonly EMSContext db;
        public EmployeeController(EMSContext _db){

            db = _db;
        }


        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = db.Employee.ToList();
            return employees;
        }

        [HttpPost]
        public int Create(Employee employee)
        {
            db.Employee.Add(employee);
            db.SaveChanges();

            return 1;
        }
    }
}
