﻿using ApiHealthCheck.Lib.Credentials;

namespace ApiHealthCheck.Lib
{
    public interface IHealthCheck
    {
        bool IsApiHealthy(string url, ProductApiCredential? credential = null);
    }
}