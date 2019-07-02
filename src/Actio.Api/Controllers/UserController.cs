namespace Actio.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Actio.Common.Commands;
    using Microsoft.AspNetCore.Mvc;
    using RawRabbit;

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IBusClient _busClient;
        public UserController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            Console.WriteLine("[POST]");
            await _busClient.PublishAsync(command);
            return  Accepted();
        }
    }
}