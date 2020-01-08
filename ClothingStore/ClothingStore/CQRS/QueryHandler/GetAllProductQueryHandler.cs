using ClothingStore.Data;
using ClothingStore.Data.QueryRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore
{
    public class GetAllProductQueryHandler : IQueryHandler<GetAllProductQuery>
    {
        private readonly IProductQueryRespository _productQueryRepository;
        public GetAllProductQueryHandler(IProductQueryRespository productQueryRepository)
        {
            _productQueryRepository = productQueryRepository;
        }

        public async Task<IQueryResult> ExecuteAsync(GetAllProductQuery query)
        {
            var listMenu = _productQueryRepository.Entities.Where(p => !query.IsDeleted).AsEnumerable();

            return await Task.FromResult(new QueryResult<IEnumerable<Product>>()
            {
                Success = true,
                Data = listMenu
            });
        }
    }
}