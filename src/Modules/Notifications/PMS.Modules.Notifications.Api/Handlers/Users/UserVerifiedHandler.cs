using PMS.Modules.Notifications.Api.Services;
using PMS.Modules.Users.Shared.Events;
using PMS.Shared.Events;

namespace PMS.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserVerifiedHandler : IEventHandler<UserVerified>
{
    private readonly IEmailSender _emailSender;

    public UserVerifiedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task HandleAsync(UserVerified @event, CancellationToken cancellationToken = default)
        => _emailSender.SendAsync(@event.Email, "account_verified");
}