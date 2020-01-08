using System.Linq;

namespace ClothingStore.Data
{
    public interface IQueryRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Entities
        {
            get;
        }
    }
}
