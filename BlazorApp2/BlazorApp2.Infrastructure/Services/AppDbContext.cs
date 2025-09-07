using BlazorApp2.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Infrastructure.Services;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options): base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}