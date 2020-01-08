
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public class ProductCommandRespository : IProductCommandRespository
    {
        private ICommandContext<Product> _context;
        public ProductCommandRespository(ICommandContext<Product> context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.GetDataSet().Add(product);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public Task<Product> FindAsync(Guid productId)
        {
            return _context.GetDataSet()
                .Where(e => e.Id == productId)
                .FirstOrDefaultAsync();
        }
    }
}
