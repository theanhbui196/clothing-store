using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public class DatabaseCommandContext : ClothingStoreEntities,
        ICommandContext<Product>
    {
        DbSet<Product> ICommandContext<Product>.GetDataSet() => Products;
    }
}
