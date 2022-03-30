using PMS.Modules.Users.Shared.DTO;

namespace PMS.Modules.Users.Shared;

public interface IUsersModuleApi
{
    Task<UserDetailsDto> GetUserAsync(Guid userId);
    Task<UserDetailsDto> GetUserAsync(string email);
}