using BlazorApp2.Core.Entities;
using MediatR;

namespace BlazorApp2.Application.Users.Queries.GetUser;

public record GetUserQuery(Guid Id): IRequest<User?>;
