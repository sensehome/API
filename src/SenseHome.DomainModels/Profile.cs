using SenseHome.DomainModels.Base;

namespace SenseHome.DomainModels
{
    public class Profile : BaseEntityWithLog
    {
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; } //TODO: verify that a user exist with that Id
        public virtual User User { get; set; }
    }
}
