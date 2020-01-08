using System.Threading.Tasks;

namespace ClothingStore
{
    public interface ICommandDispatcher
    {
        Task<ICommandResult> DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
