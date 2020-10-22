using SenseHome.DomainModels.Base;
using System;

namespace SenseHome.DomainModels
{
    public class Subscription : BaseEntity
    {
        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            private set { _CreatedDate = DateTime.Now; }
        }
        public DateTime ExpireDate { get; set; }
        public string[] Path { set; get; }
        public string UserId { get; set; }
        public virtual User User {get; set;}
    }
}
