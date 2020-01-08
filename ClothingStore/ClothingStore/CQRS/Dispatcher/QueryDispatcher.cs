using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClothingStore
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public async Task<IQueryResult> DispatchAsync<TQuery>(TQuery query) where TQuery : IQuery
        {
            var handler = (IQueryHandler<TQuery>)DependencyResolver.Current.GetService(typeof(IQueryHandler<TQuery>));
            if (!((handler != null) && handler is IQueryHandler<TQuery>))
            {
                throw new Exception();
            }
            return await handler.ExecuteAsync(query);
        }
    }
}