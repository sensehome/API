using SenseHome.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionDto : BaseDtoWithLog
    {
        public DateTime ExpireDate { get; set; }
        public string[] Path { set; get; }
        public string UserId { get; set; }
    }
}
