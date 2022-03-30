using PMS.Shared.Exceptions;

namespace PMS.Modules.Users.Core.Exceptions;

internal sealed class InvalidEmailException : PMSException
{
    public string Email { get; }

    public InvalidEmailException(string email) : base($"Email: '{email}' is invalid.")
    {
        Email = email;
    }
}