using BlazorApp2.Core.Entities;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.DeleteUser;

public record DeleteUserCommand(Guid Id): IRequest<User?>;
