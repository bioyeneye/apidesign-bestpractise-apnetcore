namespace BestPractiseApi.models
{
    public class PaginatedResultMetaData
    {
        public PaginatedResultMetaData(PaginationResultSet resultSet)
        {
            ResultSet = resultSet;
        }

        public PaginationResultSet ResultSet { get; }
    }
}