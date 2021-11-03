using Microsoft.AspNetCore.Http;
using System;

namespace BookClub.Infrastructure.Middleware
{
    public class ApiExceptionOptions
    {
        public Action<HttpContext, Exception, ApiError> AddResponseDetails { get; set; }
    }
}
