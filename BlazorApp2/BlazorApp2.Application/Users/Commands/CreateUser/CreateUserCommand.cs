using BlazorApp2.Core.Entities;
using MediatR;

namespace BlazorApp2.Application.Users.Commands.CreateUser;

public record CreateUserCommand(string FirstName, string LastName, int Age, bool IsMarried): IRequest<User>;