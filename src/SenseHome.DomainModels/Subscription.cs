using SenseHome.DomainModels.Base;
using System;

namespace SenseHome.DomainModels
{
    public class Subscription : BaseEntity
    {
        public DateTime CreatedDate
        {
            get { return createdDate; }
            private set { createdDate = DateTime.Now; }
        }
        public DateTime ExpireDate { get; set; }
        public string[] Path { set; get; }
        public string UserId { get; set; }
        public virtual User User {get; set;}
    }
}
