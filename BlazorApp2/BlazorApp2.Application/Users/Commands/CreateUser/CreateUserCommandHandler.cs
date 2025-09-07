using BlazorApp2.Core.Entities;
using BlazorApp2.Core.Interfaces;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.CreateUser;

internal class CreateUserCommandHandler: IRequestHandler<CreateUserCommand, User>
{
    private readonly IUsersRepository _repository;

    public CreateUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            IsMarried = request.IsMarried
        };

        return await _repository.CreateUserAsync(user, cancellationToken);
    }
}
