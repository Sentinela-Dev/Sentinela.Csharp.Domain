namespace Sentinela.Domain.Exceptions;

public class EntityExistsException : Exception
{
    public EntityExistsException(string msg) : base(msg) { }
}
