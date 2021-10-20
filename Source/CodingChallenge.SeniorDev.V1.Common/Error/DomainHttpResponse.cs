using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Error
{
    public abstract class DomainHttpResponse: Exception
    {
        public DomainHttpResponse(string message):base(message)
        {

        }
        public class DomainNotFoundException : DomainHttpResponse
        {
            public DomainNotFoundException(string message) : base(message)
            {

            }
        }

        public class UnauthorizedException : DomainHttpResponse
        {
            public UnauthorizedException(string message = "Unauthorized Access") : base(message)
            {

            }
        }

        public class BadRequestException : DomainHttpResponse
        {
            public BadRequestException(string message = "Bad Request") : base(message)
            {

            }
        }
    }
}
