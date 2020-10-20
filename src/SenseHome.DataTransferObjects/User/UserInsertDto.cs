using SenseHome.Common.Enums;
using SenseHome.DataTransferObjects.Base;
using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.User
{
    public class UserInsertDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        public UserType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
