using PMS.Shared.Exceptions;

namespace PMS.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyExistsException : PMSException
{
    public string Email { get; }

    public UserAlreadyExistsException(string email) : base($"User with email: '{email}' already exists.")
    {
        Email = email;
    }
}