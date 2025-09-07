using BlazorApp2.Core.Entities;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.UpdateUser;

public record UpdateUserCommand(Guid Id, string FirstName, string LastName, int Age, bool IsMarried): IRequest<User?>;