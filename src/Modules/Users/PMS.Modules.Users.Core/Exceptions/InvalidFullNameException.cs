using PMS.Shared.Exceptions;

namespace PMS.Modules.Users.Core.Exceptions;

internal sealed class InvalidFullNameException : PMSException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}