namespace FoSouzaDev.Common.Domain.Exceptions;

public sealed class NotFoundException(Guid id) : Exception(message: "Not found.")
{
    public Guid Id => id;
}