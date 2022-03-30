using PMS.Shared.Exceptions;

namespace PMS.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyVerifiedException : PMSException
{
    public Guid UserId { get; }

    public UserAlreadyVerifiedException(Guid userId) : base($"User with ID: '{userId}' is already verified.")
    {
        UserId = userId;
    }
}