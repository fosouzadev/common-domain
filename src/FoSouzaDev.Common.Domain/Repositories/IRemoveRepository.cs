using FoSouzaDev.Common.Domain.Entities;

namespace FoSouzaDev.Common.Domain.Repositories;

public interface IRemoveRepository<T> where T : Entity
{
    Task RemoveAsync(Guid id);
}