namespace BestPractiseApi.models
{
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