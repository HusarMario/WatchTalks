using Microsoft.EntityFrameworkCore;
using WatchTalks.Data;
using WatchTalks.Interfaces;

namespace WatchTalks.Repositories;

public class CrudOperationsAsync<T> : ICrudOperationsAsync<T> where T : class
{
        private readonly ApplicationDbContext _dbContext;
        public CrudOperationsAsync(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);             //apply on SaveChanges()
            return entity;
        }

        public Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;  //apply on SaveChanges()
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);                     //apply on SaveChanges()
            return Task.CompletedTask;
        }
}