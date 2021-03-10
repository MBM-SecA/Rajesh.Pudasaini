using Microsoft.AspNetCore.Mvc;
using EMSApi.Data;
using EMSApi.Models;
using System.Linq;

namespace EMSApi.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController: ControllerBase {

        private readonly EMSContext db;
        public OrganizationController(EMSContext db) {
            this.db = db;
        }

        [HttpGet]
        public Organization[] Get(){
            var organizations = db.Organization.ToArray();
            return organizations; 
        }

        [HttpPost]
        public string CreateOrganization(Organization organization){
            db.Organization.Add(organization);
            db.SaveChanges(); //returns number of rows affected
            return "organization created";

        }
    }
}