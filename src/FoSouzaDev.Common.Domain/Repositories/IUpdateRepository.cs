using FoSouzaDev.Common.Domain.Entities;

namespace FoSouzaDev.Common.Domain.Repositories;

public interface IUpdateRepository<T> where T : Entity
{
    Task UpdateAsync(T entity);
}