namespace WatchTalks.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> CommitAsync();
}