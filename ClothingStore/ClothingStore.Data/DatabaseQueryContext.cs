using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public class DatabaseQueryContext : ClothingStoreEntities,
        IQueryContext<Product>
    {
        DbSet<Product> IQueryContext<Product>.GetDataSet() => Products;
    }
}
