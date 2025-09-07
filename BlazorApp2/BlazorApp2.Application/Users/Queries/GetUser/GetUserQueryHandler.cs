using BlazorApp2.Core.Entities;
using BlazorApp2.Core.Interfaces;
using MediatR;

namespace BlazorApp2.Application.Users.Queries.GetUser;

internal class GetUserQueryHandler: IRequestHandler<GetUserQuery, User?>
{
    private readonly IUsersRepository _repository;

    public GetUserQueryHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetUserAsync(request.Id, cancellationToken);
    }
}
