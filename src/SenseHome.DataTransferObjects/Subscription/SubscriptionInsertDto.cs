using SenseHome.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionInsertDto : BaseDtoWithLog
    {
        public string[] Path { set; get; }
        public string UserId { get; set; }
    }
}
