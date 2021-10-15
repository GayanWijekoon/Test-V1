using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Business.Actions.Courses;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class CoursesController : BaseController
    {
        public CoursesController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration)
            : base(mediator, configuration)
        {}

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<CourseModel>>> GetAll()
        {
            var result = await mediator.Send(new GetAllCoursesQuery());
            return Ok(result.CourseList);
        }

        [HttpPost]
        public async Task<ActionResult> EnrollToCourse()
        {
            return Ok();
        }
    }
}
