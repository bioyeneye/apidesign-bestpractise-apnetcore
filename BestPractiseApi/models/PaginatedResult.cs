using System.Collections.Generic;

namespace BestPractiseApi.models
{
    public class PaginatedResult<T>
    {
        public PaginatedResultMetaData MetaData { get; }
        public List<T> Results { get; }

        public PaginatedResult(PaginatedResultMetaData metaData, List<T> results)
        {
            MetaData = metaData;
            Results = results;
        }
    }
}