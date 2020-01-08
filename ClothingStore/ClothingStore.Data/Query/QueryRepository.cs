using System;
using System.Linq;

namespace ClothingStore.Data
{
    public abstract class QueryRepository<TEntity> : IQueryRepository<TEntity> where TEntity : BaseEntity
    {
        protected QueryRepository(IQueryContext<TEntity> context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IQueryContext<TEntity> Context
        {
            get;
        }

        public virtual IQueryable<TEntity> Entities
        {
            get
            {
                return Context.GetDataSet().AsNoTracking();
            }
        }
    }
}
