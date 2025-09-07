using BlazorApp2.Core.Entities;
using BlazorApp2.Core.Interfaces;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler: IRequestHandler<UpdateUserCommand, User?>
{
    private readonly IUsersRepository _repository;
    
    public UpdateUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<User?> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetUserAsync(request.Id, cancellationToken);
        if (user == null) return null;
        
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Age = request.Age;
        user.IsMarried = request.IsMarried;

        await _repository.UpdateUserAsync(user, cancellationToken);
        return user;
    }
}