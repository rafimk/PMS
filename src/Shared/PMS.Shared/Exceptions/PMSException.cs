namespace PMS.Shared.Exceptions;

public abstract class PMSException  : Exception
{
    protected PMSException(string message) : base(message)
    {
    }
}
