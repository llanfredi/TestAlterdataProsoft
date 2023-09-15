using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration.Configuration
{
    public static class EnvironmentConfiguration
    {
        public static readonly string ENV = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
        public static readonly string LOCAL = "LOCAL";
        public static readonly string DEV = "DEV";
        public static readonly string UAT = "UAT";
        public static readonly string PROD = "PROD";
        private static readonly string[] _localEnvironmentNames = { LOCAL, DEV };
        private static readonly string[] _notProductionEnvironmentNames = { LOCAL, DEV, UAT };
        private static readonly string[] _secretManagementEnvironmentNames = { DEV, UAT, PROD };

        public static bool IsProdEnvironment { get => ENV == PROD; }

        public static bool IsLocal() 
        {
            return _localEnvironmentNames.Contains(ENV);
        }

        public static bool NotProd() 
        {
            return _notProductionEnvironmentNames.Contains(ENV);
        }

        public static bool IsSecretManagementEnvironment() 
        {
            return _secretManagementEnvironmentNames.Contains(ENV);
        }
    }
}
