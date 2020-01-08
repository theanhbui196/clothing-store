using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClothingStore
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public async Task<ICommandResult> DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = (ICommandHandler<TCommand>) DependencyResolver.Current.GetService(typeof(ICommandHandler<TCommand>));
            if (!((handler != null) && handler is ICommandHandler<TCommand>))
            {
                throw new Exception();
            }
            return await handler.ExecuteAsync(command);
        }
    }
}
