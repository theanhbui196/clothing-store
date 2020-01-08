using System.Data.Entity;

namespace ClothingStore.Data
{
    public interface IQueryContext<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> GetDataSet();
    }
}
