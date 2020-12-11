using System;
using System.Collections.Generic;
using SenseHome.Common.Enums;
using SenseHome.DomainModels.Base;

namespace SenseHome.DomainModels
{
    public class User : BaseEntityWithLog
    {
        public string Name { get; set; } //TODO: User Name will be unique
        public string Password { get; set; }
        public UserType Type { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime LastConnected { get; set; } = DateTime.MinValue;
        public List<DateTime> Logs { get; set; }
        public virtual Subscription[] Subscriptions { get; set; }
    }
}