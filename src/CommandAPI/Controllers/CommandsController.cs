using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.CommandsController
{
    [Route("api/Commands")]
    public class CommandsController : ControllerBase
    {
        ICommandAPIRepo _commandAPIRepo;

        public CommandsController(ICommandAPIRepo commandAPIRepo)
        {
            _commandAPIRepo = commandAPIRepo;
        }

        //Add the following code
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _commandAPIRepo.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _commandAPIRepo.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}