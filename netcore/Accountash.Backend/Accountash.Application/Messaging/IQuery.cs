using MediatR;

namespace Accountash.Application.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse> 
{
}
