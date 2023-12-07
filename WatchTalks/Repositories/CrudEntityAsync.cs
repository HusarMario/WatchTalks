using Microsoft.EntityFrameworkCore;
using WatchTalks.Data;
using WatchTalks.Entities;
using WatchTalks.Interfaces;

namespace WatchTalks.Repositories;

public class CrudEntityAsync : CrudOperationsAsync<User>, ICrudEntityAsync<User>
{
    private readonly DbSet<User> _user;
    public CrudEntityAsync(ApplicationDbContext dbContext) : base(dbContext)
    {
        _user = dbContext.Set<User>();
    }
    
}