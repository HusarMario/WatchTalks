using WatchTalks.Entities;

namespace WatchTalks.Interfaces;

public interface ICrudEntityAsync<T> : ICrudOperationsAsync<T> where T : class
{
    
}