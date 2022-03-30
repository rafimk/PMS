using PMS.Modules.Notifications.Api.Services;
using PMS.Modules.Users.Shared.Events;
using PMS.Shared.Events;

namespace PMS.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserCreatedHandler : IEventHandler<UserCreated>
{
    private readonly IEmailSender _emailSender;

    public UserCreatedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task HandleAsync(UserCreated @event, CancellationToken cancellationToken = default)
        => _emailSender.SendAsync(@event.Email, "account_created");
}