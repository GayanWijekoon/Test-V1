using CodingChallenge.SeniorDev.V1.Common.Configuration;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CodingChallenge.SeniorDev.V1.API.Controllers.Definitions
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator mediator;
        protected readonly IOptionsSnapshot<CodingChallengeConfiguration> configuration;
        private readonly ILogger<StudentsController> logger;

        public BaseController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration, ILogger<StudentsController> logger) : base()
        {
            this.mediator = mediator;
            this.configuration = configuration;
            this.logger = logger;
        }
    }
}
