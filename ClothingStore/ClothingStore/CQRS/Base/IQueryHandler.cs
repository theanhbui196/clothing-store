using System.Threading.Tasks;

namespace ClothingStore
{
    public interface IQueryHandler<TQuery> where TQuery : IQuery
    {
        Task<IQueryResult> ExecuteAsync(TQuery query);
    }
}
