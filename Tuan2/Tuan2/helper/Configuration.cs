using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayPal.Api;

namespace Tuan2.helper
{
    public static class Configuration
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;
        static Configuration()
        {
            var config = GetConfig();
            ClientId = "AcaUdoPR1nhmWC2R_Jj4ZiRlhFW81lmM6fdOby7QdJZqPfdvuvirV4wIyUK8m8x36ejt28pfYqhOKPpe";
            ClientSecret = "EJ6SfZDlA1WHUqExCkt9vfkan3CZDaX3qXm3HK2eHCbBIvVB2lRV-h1n0wGRbgzgraJ8BlENaEYHnFaN";
        }
        public static Dictionary<string, string> GetConfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}