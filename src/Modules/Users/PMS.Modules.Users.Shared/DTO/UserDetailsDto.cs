using System.ComponentModel.DataAnnotations;

namespace PMS.Modules.Users.Shared.DTO;

public class UserDetailsDto : UserDto
{
    [Required]
    public string Address { get; set; }
        
    [Required]
    public string Identity { get; set; }
}