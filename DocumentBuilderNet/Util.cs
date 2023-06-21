using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Configuration;


namespace DocumentBuilderNet
{
    internal class Util
    {
        public static async Task<string> GetRemedyServiceJWT()
        {
            //Get Configuration and init form values
            var user = ConfigurationManager.AppSettings.Get("username");
            var pass = ConfigurationManager.AppSettings.Get("password");
            var auth = ConfigurationManager.AppSettings.Get("authstring");

            if (user == null || pass == null || auth == null)
                throw new ArgumentNullException("Configuration file is missing username, password or authstring.");

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                {"username", user}, {"password", pass}, {"authstring", auth}
            };

            // Request JWT Key
            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("Accept", "application/x-www-form-urlencoded");

            FormUrlEncodedContent content = new FormUrlEncodedContent(keyValuePairs);
            HttpResponseMessage response = await client.PostAsync(Constants.AuthUrl(), content);
            response.EnsureSuccessStatusCode();

            string key = await response.Content.ReadAsStringAsync();
            return key;
        }

        public static async Task GetRemedyFormEntry(string id)
        {
            // Request JWT Key
            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("Accept", "application/x-www-form-urlencoded");



        }

        struct AuthenticationDetails
        {
            public string username;
            public string password;
            public string authstring;

            public AuthenticationDetails()
            {
                var user = ConfigurationManager.AppSettings.Get("username");
                var pass = ConfigurationManager.AppSettings.Get("password");
                var auth = ConfigurationManager.AppSettings.Get("authstring");

                if (user == null || pass == null || auth == null)
                    throw new ArgumentNullException("Configuration file is missing username, password or authstring.");
                else
                {
                    username = user;
                    password = pass;
                    authstring = auth;
                }

            }
        }

        struct RemedyFormObject
        {
            public object values;
        }
    }
}
