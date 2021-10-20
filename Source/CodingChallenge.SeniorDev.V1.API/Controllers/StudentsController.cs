using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CodingChallenge.SeniorDev.V1.Common.Error.DomainHttpResponse;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class StudentsController : BaseController
    {
        public ILogger<StudentsController> _logger { get; }

        public StudentsController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration, ILogger<StudentsController> logger)
            : base(mediator, configuration, logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<StudentModel>>> GetAll()
        {
            _logger.LogInformation("new test log");
            throw new UnauthorizedException();
            return null;
        }

        [HttpPost]
        public async Task<ActionResult<StudentModel>> Create(StudentCreateModel request)
        {
            return null;
        }

        [HttpPut]
        public async Task<ActionResult<List<string>>> Delete(StudentDeleteModel request)
        {
            return null;
        }
    }
}
