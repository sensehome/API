using SenseHome.Common.Enums;
using SenseHome.DataTransferObjects.Base;
using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.User
{
    public class UserUpdateDto :  BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public UserType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
