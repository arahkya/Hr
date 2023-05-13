using Hr.Domains.Common.Interfaces;

namespace Hr.Application.Interfaces;

public interface IApplicationDbContext
{
    Task<int> AddAsync<T>(T entity) where T : IEntity;
    Task CommitAsync();
}