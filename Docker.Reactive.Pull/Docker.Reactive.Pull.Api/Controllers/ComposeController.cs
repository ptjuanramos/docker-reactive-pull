using Docker.Reactive.Pull.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.Reactive.Pull.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComposeController : ControllerBase
    {
        private readonly ILogger<ComposeController> _logger;

        public ComposeController(ILogger<ComposeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<OperationResult> PullAndRun()
        {
            return null;
        }
    }
}
