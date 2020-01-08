
using System;
using System.Threading.Tasks;

namespace ClothingStore.Data
{
    public abstract class CommandRepository<TEntity> where TEntity : BaseEntity
    {
        protected CommandRepository(ICommandContext<TEntity> context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected ICommandContext<TEntity> Context
        {
            get;
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
