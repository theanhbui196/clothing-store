namespace ClothingStore.Data
{
    public class QueryResult<T> : IQueryResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
