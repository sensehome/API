using System;
namespace SenseHome.API.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int TokenValidityInDays { get; set; }
    }
}
