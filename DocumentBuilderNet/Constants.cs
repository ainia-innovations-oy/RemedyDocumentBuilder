using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DocumentBuilderNet
{
    internal class Constants
    {
        public static readonly string basePath = ConfigurationManager.AppSettings.Get("basePath");

        private static string BaseUrl = ConfigurationManager.AppSettings.Get("baseurl");
        private static string TargetEntity = ConfigurationManager.AppSettings.Get("targetEntity");
        public static string EntryUrl(string id) => string.Format("{0}/arsys/v1/entry/{1}/{2}", BaseUrl, TargetEntity, id);
        public static string AuthUrl() => string.Format("{0}/jwt/login", BaseUrl); 
    }
}
