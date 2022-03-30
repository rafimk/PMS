using PMS.Modules.Notifications.Shared;

namespace PMS.Modules.Notifications.Api.Services;

internal sealed class NotificationsModuleApi : INotificationsModuleApi
{
    private readonly IEmailSender _emailSender;

    public NotificationsModuleApi(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task SendEmailAsync(string receiver, string template)
        => _emailSender.SendAsync(receiver, template);
}