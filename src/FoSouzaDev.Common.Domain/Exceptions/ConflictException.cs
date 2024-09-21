namespace FoSouzaDev.Common.Domain.Exceptions;

public sealed class ConflictException(Guid id) : Exception(message: "Already registered.")
{
    public Guid Id => id;
}