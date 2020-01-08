using System.Threading.Tasks;

namespace ClothingStore
{
    public interface ICommandHandler<TCommand> where TCommand: ICommand
    {
        Task<ICommandResult> ExecuteAsync(TCommand command);
    }
}
