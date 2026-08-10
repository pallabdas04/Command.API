using CommandAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommandById(int Id)
        {
            var commandItem = await _repository.GetCommandById(Id);
            if (commandItem is null)
                return NotFound();
            
            return Ok(commandItem);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCommands()
        {
            var commandItems = await _repository.GetAllCommands();
            return Ok(commandItems);
        }
    }
}