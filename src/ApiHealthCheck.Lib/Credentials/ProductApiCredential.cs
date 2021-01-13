﻿namespace ApiHealthCheck.Lib.Credentials
{
    public record ProductApiCredential : IApiCredential
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public ProductApiCredential()
        {
            UserName = string.Empty;
            Password = string.Empty;
        }
    }
}