using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class InfoController : BaseController
    {
        public InfoController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration)
            : base(mediator, configuration)
        { }

        [HttpGet]
        [Route("")]
        public InfoConfig Get()
            => configuration.Value.Info;
    }
}
