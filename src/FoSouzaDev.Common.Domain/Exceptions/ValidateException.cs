namespace FoSouzaDev.Common.Domain.Exceptions;

public sealed class ValidateException(string message) : Exception(message)
{
}