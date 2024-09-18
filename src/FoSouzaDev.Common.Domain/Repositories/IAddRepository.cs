using FoSouzaDev.Common.Domain.Entities;

namespace FoSouzaDev.Common.Domain.Repositories;

public interface IAddRepository<T> where T : Entity
{
    Task AddAsync(T entity);
}