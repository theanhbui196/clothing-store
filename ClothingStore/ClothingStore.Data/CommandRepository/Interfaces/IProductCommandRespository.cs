using System;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public interface IProductCommandRespository
    {
        void Add(Product product);
        Task<Product> FindAsync(Guid productId);
        Task<int> SaveChangesAsync();
    }
}
