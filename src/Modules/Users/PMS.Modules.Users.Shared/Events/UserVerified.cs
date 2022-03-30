using PMS.Shared.Events;

namespace PMS.Modules.Users.Shared.Events;

public record UserVerified(Guid UserId, string Email, string Nationality) : IEvent;