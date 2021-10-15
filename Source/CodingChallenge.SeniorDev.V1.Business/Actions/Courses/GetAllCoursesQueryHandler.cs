using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Courses
{
    public class GetAllCoursesQuery : IRequest<GetAllCoursesQueryResult>
    {

    }

    public class GetAllCoursesQueryResult
    {
        public List<CourseModel> CourseList { get; set; }
    }

    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, GetAllCoursesQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllCoursesQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<GetAllCoursesQueryResult> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var courses = await dataContext.GetAllCourses();

            return new GetAllCoursesQueryResult
            {
                CourseList = mapper.Map<List<CourseModel>>(courses)
            };
        }
    }
}
