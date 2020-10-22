using SenseHome.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenseHome.DataTransferObjects.Profile
{
    public class ProfileDto : BaseDtoWithLog
    {
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

    }
}
