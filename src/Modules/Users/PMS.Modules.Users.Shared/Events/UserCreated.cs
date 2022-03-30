using PMS.Shared.Events;

namespace PMS.Modules.Users.Shared.Events;

public record UserCreated(Guid UserId, string Email, string FullName, string Nationality) : IEvent;