using BlazorApp2.Core.Entities;

namespace BlazorApp2.Core.Interfaces;

public interface IUsersRepository
{
    public Task<User> CreateUserAsync(User user, CancellationToken cancellationToken);
    public Task<User?> GetUserAsync(Guid id, CancellationToken cancellationToken);
    public Task<User?> DeleteUserAsync(Guid id, CancellationToken cancellationToken);
}
 