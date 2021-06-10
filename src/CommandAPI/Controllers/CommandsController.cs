using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var a = new List<string>();
            a.Add("Buğra");
            a.Add("Kerem");
            a.Add("Arda");
            a.Add("Uğur");
            return a;



        }
    }



}