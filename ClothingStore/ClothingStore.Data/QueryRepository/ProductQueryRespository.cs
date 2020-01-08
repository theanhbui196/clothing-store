
namespace ClothingStore.Data.QueryRepository
{
    public class ProductQueryRespository : QueryRepository<Product>, IProductQueryRespository
    {
        public ProductQueryRespository(IQueryContext<Product> context)
            : base(context)
        {
        }
    }
}
