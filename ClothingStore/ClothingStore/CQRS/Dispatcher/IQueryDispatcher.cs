using System.Threading.Tasks;

namespace ClothingStore
{
    public interface IQueryDispatcher
    {
        Task<IQueryResult> DispatchAsync<TQuery>(TQuery query) where TQuery : IQuery;
    }
}