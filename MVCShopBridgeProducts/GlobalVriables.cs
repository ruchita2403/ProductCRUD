using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace MVCShopBridgeProducts
{
    public  static class GlobalVriables
    {
        public static HttpClient WebapiClient = new HttpClient();

        static GlobalVriables()
        {
            WebapiClient.BaseAddress = new Uri("http://localhost:60325//api/");
            WebapiClient.DefaultRequestHeaders.Clear();
            WebapiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}