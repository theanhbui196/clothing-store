using System.Data.Entity;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public interface ICommandContext<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> GetDataSet();
        Task<int> SaveChangesAsync();
    }
}
