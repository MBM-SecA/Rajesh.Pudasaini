using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class DemoController : ControllerBase
    {
        [HttpGet("getname")]
        public string[] GetName(){
            return new string[] {"rajesh", "ram", "shyam"};
        }

        [HttpGet("getname/{int}")]
        public string GetName(int id){
            return "rajesh";
        }

    }

}