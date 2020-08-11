using System.Collections.Generic;

namespace CsharpProjectLibrary.models
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
    
    public class PaginatedResultMetaData
    {
        public PaginatedResultMetaData(PaginationResultSet resultSet)
        {
            ResultSet = resultSet;
        }

        public PaginationResultSet ResultSet { get; }
    }
    
    public class PaginationResultSet
    {
        public PaginationResultSet(int count, int offset, int limit)
        {
            Count = count;
            Offset = offset;
            Limit = limit;
        }

        public int Count { get; }
        public int Offset { get; }
        public int Limit { get; }
    }
}