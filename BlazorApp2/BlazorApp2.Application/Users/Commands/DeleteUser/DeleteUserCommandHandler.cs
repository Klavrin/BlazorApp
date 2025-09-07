using BlazorApp2.Core.Entities;
using BlazorApp2.Core.Interfaces;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler: IRequestHandler<DeleteUserCommand, User?>
{
    private readonly IUsersRepository _repository;

    public DeleteUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return await _repository.DeleteUserAsync(request.Id, cancellationToken);
    }
}
