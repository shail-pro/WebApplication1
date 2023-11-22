﻿namespace WebApplication1.Controllers
{
    public class JwtConfigurationOptions
    {
        public const string JwtKey = "Jwt";
        public string Key { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string NotInLocal { get; set; } = string.Empty;
        public int ExpiryInMinutes { get; set; } = 0;
    }
}
