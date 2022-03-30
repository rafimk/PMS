using PMS.Shared.Exceptions;

namespace PMS.Modules.Users.Core.Exceptions;

internal sealed class InvalidAddressException : PMSException
{
    public string Address { get; }

    public InvalidAddressException(string address) : base($"Address: '{address}' is invalid.")
    {
        Address = address;
    }
}