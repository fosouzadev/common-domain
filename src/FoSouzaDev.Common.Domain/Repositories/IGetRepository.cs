using FoSouzaDev.Common.Domain.Entities;

namespace FoSouzaDev.Common.Domain.Repositories;

public interface IGetRepository<T> where T : Entity
{
    Task<T> GetByIdAsync(Guid id);
    Task<T> GetByIdOrThrowAsync(Guid id);
}