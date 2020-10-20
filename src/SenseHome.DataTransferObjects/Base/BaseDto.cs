using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.Base
{
    public class BaseDto
    {
        [Required]
        public string Id { get; set; }
    }
}
