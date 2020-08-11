using System.Collections.Generic;
using CsharpProjectLibrary.models;
using Microsoft.AspNetCore.Mvc;

namespace BestPractiseApi.Controllers
{
    public class BaseApiController : ControllerBase
    {
        [NonAction]
        protected PaginatedResult<T> ConstructPaginatedResult<T>(List<T> data, int count, int limit, int offset)
        {
            return new PaginatedResult<T>(
                new PaginatedResultMetaData(new PaginationResultSet(100, offset, limit)),
                data
            );
        }
    }
}