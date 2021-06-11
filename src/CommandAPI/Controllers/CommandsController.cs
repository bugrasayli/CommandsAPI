using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo repo;
        public CommandsController(ICommandAPIRepo _repo)
        {
            this.repo = _repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> Get()
        {
            var commands =   repo.GetAllCommands();
            return Ok(commands);
        }
        [HttpGet("{ID}")]
        public ActionResult<Command> Get(int ID)
        {
            var command = repo.GetCommandById(ID);
            if (command == null)
            {
                return NotFound();
            }
            return Ok(command);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Command command)
        {
            repo.CreateCommand(command);
            return Ok();
        }
        [HttpDelete("{ID}")]
        public ActionResult Delete(int ID)
        {
            var cmd = repo.GetCommandById(ID);
            repo.DeleteCommand(cmd);
            return Ok();
        }


    }



}