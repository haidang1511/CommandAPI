using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.CommandsController
{
    [Route("api/Commands")]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(){
            return new string[]{"This","is","hard","code"};
        }
    }
}