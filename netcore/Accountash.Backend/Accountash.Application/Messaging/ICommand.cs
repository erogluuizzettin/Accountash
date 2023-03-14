using MediatR;

namespace Accountash.Application.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
